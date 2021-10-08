using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using NationalInstruments.Visa;
using Excel = Microsoft.Office.Interop.Excel;

namespace Data_Reciever
{
    public partial class Form1 : Form, IView
    {
        private Controller controller;
        private int sendBytesCount = 0;
        private int receiveBytesCount = 0;
        private bool FirstByte, SecondByte = false;
        private int DataCollectCount = 0;
        private byte[] DataReceive = new byte[4];
        private byte[] StringReceive = new byte[3];
        private string pathFile = @"D:\Data Reciever\Data1";
        private int Raw = 0;
        private int DataSendCNT = 0;

        // Excel Setting
        Excel.Application excelApp;
        Excel._Workbook wBook;
        Excel._Worksheet wSheet;
        Excel.Range wRange;


        public Form1()
        {
            InitializeComponent();
            InitializeCOMCombox();
            this.statusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.toolStripStatusTx.Text = "Sent: 0";
            this.toolStripStatusRx.Text = "Received: 0";
        }
        public void SetController(Controller controller)
        {
            this.controller = controller;
        }

        public void OpenComEvent(Object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action<Object, SerialPortEventArgs>(OpenComEvent), sender, e);
                return;
            }

            if (e.isOpend)  //Open successfully
            {
                statuslabel.Text = comListCbx.Text + " Connected !";
                statuslabel.BackColor = Color.FromArgb(0, 255, 0);
                openCloseSpbtn.Text = "Close";
                sendbtn.Enabled = true;
                autoSendcbx.Enabled = true;
                //autoReplyCbx.Enabled = true;

                comListCbx.Enabled = false;
                baudRateCbx.Enabled = false;
                dataBitsCbx.Enabled = false;
                stopBitsCbx.Enabled = false;
                parityCbx.Enabled = false;
                handshakingcbx.Enabled = false;
                refreshbtn.Enabled = false;

                if (autoSendcbx.Checked)
                {
                    autoSendtimer.Start();
                    sendtbx.ReadOnly = true;
                }
            }
            else    //Open failed
            {
                statuslabel.Text = "Open failed !";
                statuslabel.BackColor = Color.FromArgb(255, 0, 0);
                sendbtn.Enabled = false;
                autoSendcbx.Enabled = false;
                //autoReplyCbx.Enabled = false;
            }
        }

        public void CloseComEvent(Object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action<Object, SerialPortEventArgs>(CloseComEvent), sender, e);
                return;
            }

            if (!e.isOpend) //close successfully
            {
                statuslabel.Text = comListCbx.Text + " Closed";
                statuslabel.BackColor = Color.FromArgb(119, 136, 153);
                openCloseSpbtn.Text = "Open";

                sendbtn.Enabled = false;
                sendtbx.ReadOnly = false;
                autoSendcbx.Enabled = false;
                //autoSendtimer.Stop();

                comListCbx.Enabled = true;
                baudRateCbx.Enabled = true;
                dataBitsCbx.Enabled = true;
                stopBitsCbx.Enabled = true;
                parityCbx.Enabled = true;
                handshakingcbx.Enabled = true;
                refreshbtn.Enabled = true;
            }
        }

        public void ComReceiveDataEvent(Object sender, SerialPortEventArgs e)
        {
            int counter = 0;
            int data = 0;
            if (this.InvokeRequired)
            {
                try
                {
                    Invoke(new Action<Object, SerialPortEventArgs>(ComReceiveDataEvent), sender, e);
                }
                catch (System.Exception)
                {
                    //disable form destroy exception
                }
                return;
            }

            if (recStrRadiobtn.Checked) //display as string
            {
                while (counter < e.receivedBytes.Length)
                {
                    if (DataCollectCount == 0)
                    {
                        if (e.receivedBytes[counter] == 0xFF)
                            FirstByte = true;

                        if (e.receivedBytes[counter] == 0xFE)
                        {
                            SecondByte = true;
                            counter++;
                        }
                    }
                    if (FirstByte & SecondByte)
                    {
                        switch (DataCollectCount)
                        {
                            case 0:
                                StringReceive[DataCollectCount] = e.receivedBytes[counter];
                                DataCollectCount++;
                                break;
                            case 1:
                                StringReceive[DataCollectCount] = e.receivedBytes[counter];
                                data = Convert.ToInt32(StringReceive[DataCollectCount] << 8);
                                DataCollectCount++;
                                break;
                            case 2:
                                StringReceive[DataCollectCount] = e.receivedBytes[counter];
                                if(StringReceive[0] == 0x00)
                                {
                                    data = data + Convert.ToInt32(StringReceive[DataCollectCount]);
                                    receivetbx.AppendText("Test Round " + data.ToString() + ":\r\n");
                                    receivetbx.ScrollToCaret();
                                    receivetbx.Refresh();
                                }
                                else if(StringReceive[0] == 0x55)
                                {
                                    data = data + Convert.ToInt32(StringReceive[DataCollectCount]);
                                    receivetbx.AppendText("\tActual RPM =  " + data.ToString() + "\r\n");
                                    receivetbx.ScrollToCaret();
                                    receivetbx.Refresh();
                                }
                                else if (StringReceive[0] == 0xAA)
                                {
                                    data = data + Convert.ToInt32(StringReceive[DataCollectCount]);
                                    receivetbx.AppendText("\tIdeal RPM =  " + data.ToString() + "\r\n");
                                    receivetbx.ScrollToCaret();
                                    receivetbx.Refresh();
                                }
                                else if (StringReceive[0] == 0xA5)
                                {
                                    data = data + Convert.ToInt32(StringReceive[DataCollectCount]);
                                    receivetbx.AppendText("\tDuty =  " + data.ToString() + "%\r\n");
                                    receivetbx.ScrollToCaret();
                                    receivetbx.Refresh();
                                }
                                else
                                {
                                    data = data + Convert.ToInt32(StringReceive[DataCollectCount]);
                                    receivetbx.AppendText("Fan " + StringReceive[0].ToString() + " have been failed for " + data.ToString() + " times.\r\n");
                                    receivetbx.ScrollToCaret();
                                    receivetbx.Refresh();
                                }
                                
                                DataCollectCount = 0;
                                FirstByte = false;
                                SecondByte = false;
                                break;
                            default:
                                break;
                        }
                    }
                    counter++;
                }
            }
            else //display as hex
            {
                while (counter < e.receivedBytes.Length)
                {
                    if (DataCollectCount == 0) {
                        if (e.receivedBytes[counter] == 0xFF)
                            FirstByte = true;

                        if (e.receivedBytes[counter] == 0xFE)
                        {
                            SecondByte = true;
                            counter++;
                        }
                    }   

                    if (FirstByte & SecondByte)
                    {
                        switch (DataCollectCount)
                        {
                            case 0:
                                DataReceive[DataCollectCount] = e.receivedBytes[counter];
                                DataCollectCount++;
                                break;
                            case 1:
                                DataReceive[DataCollectCount] = e.receivedBytes[counter];
                                DataCollectCount++;
                                break;
                            case 2:
                                DataReceive[DataCollectCount] = e.receivedBytes[counter];
                                DataCollectCount++;
                                break;
                            case 3:
                                DataReceive[DataCollectCount] = e.receivedBytes[counter];
                                DataCollectCount = 0;
                                //receivetbx.Text += "\r\n";

                                FirstByte = false;
                                SecondByte = false;
                                break;
                            default:
                                break;
                        }
                    }
                    counter++;
                }

                // Export data to Excel File
                Export2Excel(DataReceive);
                if (receivetbx.Text.Length > 0)
                    receivetbx.AppendText("-");
                receivetbx.AppendText(Controller.Bytes2Hex(DataReceive) + "\r\n");
                receivetbx.ScrollToCaret();
                receivetbx.Refresh();

                //if (receivetbx.Text.Length > 0)
                //{
                //    receivetbx.AppendText("-");
                //}
                //receivetbx.AppendText(Controller.Bytes2Hex(e.receivedBytes));
            }
            //update status bar
            receiveBytesCount += e.receivedBytes.Length;
            toolStripStatusRx.Text = "Received: " + receiveBytesCount.ToString();

            //auto reply
            //if (autoReplyCbx.Checked)
            //{
            //    sendbtn_Click(this, new EventArgs());
            //}
        }

        private void InitializeCOMCombox()
        {
            //BaudRate
            baudRateCbx.Items.Add(4800);
            baudRateCbx.Items.Add(9600);
            baudRateCbx.Items.Add(19200);
            baudRateCbx.Items.Add(38400);
            baudRateCbx.Items.Add(57600);
            baudRateCbx.Items.Add(115200);
            baudRateCbx.Items.Add(230400);
            baudRateCbx.Items.ToString();
            //get 9600 print in text
            baudRateCbx.Text = baudRateCbx.Items[4].ToString();

            //Data bits
            dataBitsCbx.Items.Add(7);
            dataBitsCbx.Items.Add(8);
            //get the 8bit item print it in the text 
            dataBitsCbx.Text = dataBitsCbx.Items[1].ToString();

            //Stop bits
            stopBitsCbx.Items.Add("One");
            stopBitsCbx.Items.Add("OnePointFive");
            stopBitsCbx.Items.Add("Two");
            //get the One item print in the text
            stopBitsCbx.Text = stopBitsCbx.Items[0].ToString();

            //Parity
            parityCbx.Items.Add("None");
            parityCbx.Items.Add("Even");
            parityCbx.Items.Add("Mark");
            parityCbx.Items.Add("Odd");
            parityCbx.Items.Add("Space");
            //get the first item print in the text
            parityCbx.Text = parityCbx.Items[0].ToString();

            //Handshaking
            handshakingcbx.Items.Add("None");
            handshakingcbx.Items.Add("XOnXOff");
            handshakingcbx.Items.Add("RequestToSend");
            handshakingcbx.Items.Add("RequestToSendXOnXOff");
            handshakingcbx.Text = handshakingcbx.Items[0].ToString();

            //Com Ports
            string[] ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length == 0)
            {
                statuslabel.Text = "No COM found !";
                statuslabel.BackColor = Color.FromArgb(255, 0, 0);
                openCloseSpbtn.Enabled = false;
            }
            else
            {
                Array.Sort(ArrayComPortsNames);
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    comListCbx.Items.Add(ArrayComPortsNames[i]);
                }
                comListCbx.Text = ArrayComPortsNames[0];
                openCloseSpbtn.Enabled = true;
            }
        }

        private void openCloseSpbtn_Click(object sender, EventArgs e)
        {
            if (openCloseSpbtn.Text == "Open")
            {
                controller.OpenSerialPort(comListCbx.Text, baudRateCbx.Text,
                    dataBitsCbx.Text, stopBitsCbx.Text, parityCbx.Text,
                    handshakingcbx.Text);

                //Open a new app program
                excelApp = new Excel.Application();

                //Make Excel Visable
                excelApp.Visible = false;

                //No Alerts Display
                excelApp.DisplayAlerts = false;

                //Add New Sheet
                excelApp.Workbooks.Add(Type.Missing);

                // Using first sheet
                wBook = excelApp.Workbooks[1];

                wBook.Activate();

                //Using the first worksheet
                wSheet = (Excel._Worksheet)wBook.Worksheets[1];

                //Name the work sheet
                wSheet.Name = "ExperimentData";

                wSheet.Activate();

                excelApp.Cells[1, 1] = "Data Measurement";

                excelApp.Cells[2, 1] = data1tbx.Text;

                excelApp.Cells[2, 2] = data2tbx.Text;

                wRange = wSheet.Range[wSheet.Cells[2, 1], wSheet.Cells[2, 2]];
                wRange.Select();
                wRange.Columns.AutoFit();

                Raw = 3;

            }
            else
            {
                controller.CloseSerialPort();
                try
                {
                    //另存活頁簿
                    wBook.SaveAs(pathFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    Console.WriteLine("儲存文件於 " + Environment.NewLine + pathFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("儲存檔案出錯，檔案可能正在使用" + Environment.NewLine + ex.Message);
                    //return false;
                }
                //關閉活頁簿
                wBook.Close(false, Type.Missing, Type.Missing);

                //關閉Excel
                excelApp.Quit();

                //釋放Excel資源
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                wBook = null;
                wSheet = null;
                wRange = null;
                excelApp = null;
                GC.Collect();

                Console.Read();
                Raw = 0;
            }
        }


        private void refreshbtn_Click(object sender, EventArgs e)
        {
            comListCbx.Items.Clear();
            //Com Ports
            string[] ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length == 0)
            {
                statuslabel.Text = "No COM found !";
                statuslabel.BackColor = Color.FromArgb(255, 0, 0);
                openCloseSpbtn.Enabled = false;
            }
            else
            {
                Array.Sort(ArrayComPortsNames);
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    comListCbx.Items.Add(ArrayComPortsNames[i]);
                }
                comListCbx.Text = ArrayComPortsNames[0];
                openCloseSpbtn.Enabled = true;
                statuslabel.Text = "OK !";
                statuslabel.BackColor = Color.FromArgb(119, 136, 153);
            }
            recieveclearbtn_Click(sender, e);
            sendclearbtn_Click(sender, e);
        }

        private void statustimer_Tick(object sender, EventArgs e)
        {
            this.statusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void recieveclearbtn_Click(object sender, EventArgs e)
        {
            receivetbx.Text = "";
            toolStripStatusRx.Text = "Received: 0";
            receiveBytesCount = 0;
        }

        private void recStrRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (recStrRadiobtn.Checked)
            {
                if (receivetbx.Text == null)
                {
                    return;
                }
                receivetbx.Text = Controller.Hex2String(receivetbx.Text);
            }
        }

        private void recHEXRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (recHEXRadiobtn.Checked)
            {
                if (receivetbx.Text == null)
                {
                    return;
                }
                receivetbx.Text = Controller.String2Hex(receivetbx.Text);
            }
        }

        private void sendStrRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sendStrRadiobtn.Checked)
            {
                if (sendtbx.Text == null)
                {
                    return;
                }
                sendtbx.Text = Controller.Hex2String(sendtbx.Text);
                //addCRCcbx.Enabled = false;
            }
        }

        private void sendHEXRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sendHEXRadiobtn.Checked)
            {
                if (sendtbx.Text == null)
                {
                    return;
                }
                sendtbx.Text = Controller.String2Hex(sendtbx.Text);
                //addCRCcbx.Enabled = true;
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            String sendText = sendtbx.Text;
            bool flag = false;
            if (sendText == null)
            {
                return;
            }
            //set select index to the end
            sendtbx.SelectionStart = sendtbx.TextLength;

            if (sendHEXRadiobtn.Checked)
            {
                //If hex radio checked
                //send bytes to serial port
                Byte[] bytes = Controller.Hex2Bytes(sendText);
                sendbtn.Enabled = false;//wait return
                flag = controller.SendDataToCom(bytes);
                sendbtn.Enabled = true;
                sendBytesCount += bytes.Length;
            }
            else
            {
                //send String to serial port
                sendbtn.Enabled = false;//wait return
                flag = controller.SendDataToCom(sendText);
                sendbtn.Enabled = true;
                sendBytesCount += sendText.Length;
            }
            if (flag)
            {
                statuslabel.Text = "Send OK !";
            }
            else
            {
                statuslabel.Text = "Send failed !";
                statuslabel.BackColor = Color.FromArgb(255, 0, 0);
            }
            //update status bar
            toolStripStatusTx.Text = "Sent: " + sendBytesCount.ToString();
        }

        private void receivedDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "txt file|*.txt";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FileName = "received.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(fName, receivetbx.Text);
            }
        }

        private void sendDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "txt file|*.txt";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FileName = "send.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(fName, sendtbx.Text);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.StartPosition = FormStartPosition.CenterParent;
            help.Show();

            if (help.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - help.Width) / 2;
                var y = Location.Y + (Height - help.Height) / 2;
                help.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }
        }

        private void sendclearbtn_Click(object sender, EventArgs e)
        {
            sendtbx.Text = "";
            toolStripStatusTx.Text = "Sent: 0";
            sendBytesCount = 0;
            //addCRCcbx.Checked = false;
        }

        private void autoSendtimer_Tick(object sender, EventArgs e)
        {
//            sendbtn_Click(sender, e);

            String sendtext = sendtbx.Text;
            string[] sendtextInfo = sendtext.Split('-');
            bool flag = false;

            if (DataSendCNT < sendtextInfo.Length)
            {
                if (sendHEXRadiobtn.Checked)
                {
                    //If hex radio checked
                    //send bytes to serial port
                    Byte[] bytes = Controller.Hex2Bytes(sendtextInfo[DataSendCNT]);
                    sendbtn.Enabled = false;//wait return
                    flag = controller.SendDataToCom(bytes);
                    sendbtn.Enabled = true;
                    sendBytesCount += bytes.Length;
                }
                else
                {
                    //send String to serial port
                    sendbtn.Enabled = false;//wait return
                    flag = controller.SendDataToCom(sendtextInfo[DataSendCNT]);
                    sendbtn.Enabled = true;
                    sendBytesCount += sendtextInfo[DataSendCNT].Length;
                }
                if (flag)
                {
                    statuslabel.Text = "Send OK !";
                }
                else
                {
                    statuslabel.Text = "Send failed !";
                }
                //update status bar
                toolStripStatusTx.Text = "Sent: " + sendBytesCount.ToString();
                DataSendCNT++;
            }
            else
            {
                DataSendCNT = 0;
                //autoSendtimer.Enabled = false;
                autoSendcbx.Checked = false;
            }

            

            /*
             * String sendText = sendtbx.Text;
            bool flag = false;
            if (sendText == null)
            {
                return;
            }
            //set select index to the end
            sendtbx.SelectionStart = sendtbx.TextLength;

            if (sendHEXRadiobtn.Checked)
            {
                //If hex radio checked
                //send bytes to serial port
                Byte[] bytes = Controller.Hex2Bytes(sendText);
                sendbtn.Enabled = false;//wait return
                flag = controller.SendDataToCom(bytes);
                sendbtn.Enabled = true;
                sendBytesCount += bytes.Length;
            }
            else
            {
                //send String to serial port
                sendbtn.Enabled = false;//wait return
                flag = controller.SendDataToCom(sendText);
                sendbtn.Enabled = true;
                sendBytesCount += sendText.Length;
            }
            if (flag)
            {
                statuslabel.Text = "Send OK !";
            }
            else
            {
                statuslabel.Text = "Send failed !";
            }
            //update status bar
            toolStripStatusTx.Text = "Sent: " + sendBytesCount.ToString();
             */
        }

        private void autoSendcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (autoSendcbx.Checked)
            {
                autoSendtimer.Enabled = true;
                autoSendtimer.Interval = int.Parse(sendIntervalTimetbx.Text);
                autoSendtimer.Start();

                //disable send botton and textbox
                sendIntervalTimetbx.Enabled = false;
                sendtbx.ReadOnly = true;
                sendbtn.Enabled = false;
            }
            else
            {
                autoSendtimer.Enabled = false;
                autoSendtimer.Stop();

                //enable send botton and textbox
                sendIntervalTimetbx.Enabled = true;
                sendtbx.ReadOnly = false;
                sendbtn.Enabled = true;
            }
        }

        private void Export2Excel(byte[] DataOut)
        {
            UInt16 Data1, Data2;

            Data1 = (UInt16)(((DataOut[0]) & 0xFF) << 8 | (DataOut[1]) & 0xFF);
            Data2 = (UInt16)(((DataOut[2]) & 0xFF) << 8 | (DataOut[3]) & 0xFF);

            excelApp.Cells[Raw, 1] = Data1.ToString();// string.Format("{0}", Data1);
            excelApp.Cells[Raw, 2] = Data2.ToString();// string.Format("{0}", Data2);

            Raw++;
            
            //
            //return true;
        }
    }
}

