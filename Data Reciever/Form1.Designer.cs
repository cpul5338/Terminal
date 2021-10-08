
namespace Data_Reciever
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comListCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.baudRateCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dataBitsCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.stopBitsCbx = new System.Windows.Forms.ToolStripComboBox();
            this.Parity = new System.Windows.Forms.ToolStripLabel();
            this.parityCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.handshakingcbx = new System.Windows.Forms.ToolStripComboBox();
            this.openCloseSpbtn = new System.Windows.Forms.ToolStripButton();
            this.refreshbtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusRx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTx = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentSpeedSenseRadiobtn = new System.Windows.Forms.RadioButton();
            this.data2tbx = new System.Windows.Forms.TextBox();
            this.data1tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.recHEXRadiobtn = new System.Windows.Forms.RadioButton();
            this.receivetbx = new System.Windows.Forms.RichTextBox();
            this.recieveclearbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendIntervalTimetbx = new System.Windows.Forms.TextBox();
            this.autoSendcbx = new System.Windows.Forms.CheckBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.sendclearbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.sendHEXRadiobtn = new System.Windows.Forms.RadioButton();
            this.sendtbx = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statustimer = new System.Windows.Forms.Timer(this.components);
            this.autoSendtimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.comListCbx,
            this.toolStripLabel2,
            this.baudRateCbx,
            this.toolStripLabel3,
            this.dataBitsCbx,
            this.toolStripLabel4,
            this.stopBitsCbx,
            this.Parity,
            this.parityCbx,
            this.toolStripLabel5,
            this.handshakingcbx,
            this.openCloseSpbtn,
            this.refreshbtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(85, 498);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 15);
            this.toolStripLabel1.Text = "Port：";
            // 
            // comListCbx
            // 
            this.comListCbx.AutoSize = false;
            this.comListCbx.Name = "comListCbx";
            this.comListCbx.Size = new System.Drawing.Size(80, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(82, 15);
            this.toolStripLabel2.Text = "Baud Rate:";
            // 
            // baudRateCbx
            // 
            this.baudRateCbx.AutoSize = false;
            this.baudRateCbx.Name = "baudRateCbx";
            this.baudRateCbx.Size = new System.Drawing.Size(80, 23);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(82, 15);
            this.toolStripLabel3.Text = "Data Bits";
            // 
            // dataBitsCbx
            // 
            this.dataBitsCbx.AutoSize = false;
            this.dataBitsCbx.Name = "dataBitsCbx";
            this.dataBitsCbx.Size = new System.Drawing.Size(80, 23);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(82, 15);
            this.toolStripLabel4.Text = "Stop Bits:";
            // 
            // stopBitsCbx
            // 
            this.stopBitsCbx.AutoSize = false;
            this.stopBitsCbx.Name = "stopBitsCbx";
            this.stopBitsCbx.Size = new System.Drawing.Size(80, 23);
            // 
            // Parity
            // 
            this.Parity.AutoSize = false;
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(82, 15);
            this.Parity.Text = "Parity:";
            // 
            // parityCbx
            // 
            this.parityCbx.AutoSize = false;
            this.parityCbx.Name = "parityCbx";
            this.parityCbx.Size = new System.Drawing.Size(80, 23);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(82, 15);
            this.toolStripLabel5.Text = "Handshaking:";
            // 
            // handshakingcbx
            // 
            this.handshakingcbx.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.handshakingcbx.AutoSize = false;
            this.handshakingcbx.Name = "handshakingcbx";
            this.handshakingcbx.Size = new System.Drawing.Size(80, 23);
            // 
            // openCloseSpbtn
            // 
            this.openCloseSpbtn.AutoSize = false;
            this.openCloseSpbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.openCloseSpbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openCloseSpbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openCloseSpbtn.Name = "openCloseSpbtn";
            this.openCloseSpbtn.Size = new System.Drawing.Size(80, 23);
            this.openCloseSpbtn.Text = "Open";
            this.openCloseSpbtn.Click += new System.EventHandler(this.openCloseSpbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.AutoSize = false;
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.refreshbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(80, 23);
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusRx,
            this.toolStripStatusTx,
            this.statusTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(85, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.ActiveLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statuslabel.AutoSize = false;
            this.statuslabel.BackColor = System.Drawing.Color.LightGray;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(150, 17);
            this.statuslabel.Text = "No Connection";
            this.statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            // 
            // toolStripStatusRx
            // 
            this.toolStripStatusRx.ActiveLinkColor = System.Drawing.SystemColors.Info;
            this.toolStripStatusRx.AutoSize = false;
            this.toolStripStatusRx.DoubleClickEnabled = true;
            this.toolStripStatusRx.Name = "toolStripStatusRx";
            this.toolStripStatusRx.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusRx.Text = "Received:";
            this.toolStripStatusRx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusTx
            // 
            this.toolStripStatusTx.AutoSize = false;
            this.toolStripStatusTx.Name = "toolStripStatusTx";
            this.toolStripStatusTx.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusTx.Text = "Sent:";
            this.toolStripStatusTx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTimeLabel
            // 
            this.statusTimeLabel.AutoSize = false;
            this.statusTimeLabel.Name = "statusTimeLabel";
            this.statusTimeLabel.Size = new System.Drawing.Size(200, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CurrentSpeedSenseRadiobtn);
            this.groupBox1.Controls.Add(this.data2tbx);
            this.groupBox1.Controls.Add(this.data1tbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.receivetbx);
            this.groupBox1.Controls.Add(this.recieveclearbtn);
            this.groupBox1.Location = new System.Drawing.Point(88, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 224);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received:";
            // 
            // CurrentSpeedSenseRadiobtn
            // 
            this.CurrentSpeedSenseRadiobtn.AutoSize = true;
            this.CurrentSpeedSenseRadiobtn.Checked = true;
            this.CurrentSpeedSenseRadiobtn.Location = new System.Drawing.Point(524, 17);
            this.CurrentSpeedSenseRadiobtn.Name = "CurrentSpeedSenseRadiobtn";
            this.CurrentSpeedSenseRadiobtn.Size = new System.Drawing.Size(102, 19);
            this.CurrentSpeedSenseRadiobtn.TabIndex = 3;
            this.CurrentSpeedSenseRadiobtn.TabStop = true;
            this.CurrentSpeedSenseRadiobtn.Text = "Sense Current";
            this.CurrentSpeedSenseRadiobtn.UseVisualStyleBackColor = true;
            // 
            // data2tbx
            // 
            this.data2tbx.Location = new System.Drawing.Point(433, 15);
            this.data2tbx.Name = "data2tbx";
            this.data2tbx.Size = new System.Drawing.Size(74, 23);
            this.data2tbx.TabIndex = 9;
            this.data2tbx.Text = "Speed(rpm)";
            this.data2tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // data1tbx
            // 
            this.data1tbx.Location = new System.Drawing.Point(299, 15);
            this.data1tbx.Name = "data1tbx";
            this.data1tbx.Size = new System.Drawing.Size(74, 23);
            this.data1tbx.TabIndex = 8;
            this.data1tbx.Text = "Current(A)";
            this.data1tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data 1:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recStrRadiobtn);
            this.panel1.Controls.Add(this.recHEXRadiobtn);
            this.panel1.Location = new System.Drawing.Point(6, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 23);
            this.panel1.TabIndex = 5;
            // 
            // recStrRadiobtn
            // 
            this.recStrRadiobtn.AutoSize = true;
            this.recStrRadiobtn.Checked = true;
            this.recStrRadiobtn.Location = new System.Drawing.Point(9, 2);
            this.recStrRadiobtn.Name = "recStrRadiobtn";
            this.recStrRadiobtn.Size = new System.Drawing.Size(58, 19);
            this.recStrRadiobtn.TabIndex = 1;
            this.recStrRadiobtn.TabStop = true;
            this.recStrRadiobtn.Text = "String";
            this.recStrRadiobtn.UseVisualStyleBackColor = true;
            this.recStrRadiobtn.CheckedChanged += new System.EventHandler(this.recStrRadiobtn_CheckedChanged);
            // 
            // recHEXRadiobtn
            // 
            this.recHEXRadiobtn.AutoSize = true;
            this.recHEXRadiobtn.Location = new System.Drawing.Point(73, 2);
            this.recHEXRadiobtn.Name = "recHEXRadiobtn";
            this.recHEXRadiobtn.Size = new System.Drawing.Size(47, 19);
            this.recHEXRadiobtn.TabIndex = 2;
            this.recHEXRadiobtn.Text = "Hex";
            this.recHEXRadiobtn.UseVisualStyleBackColor = true;
            this.recHEXRadiobtn.CheckedChanged += new System.EventHandler(this.recHEXRadiobtn_CheckedChanged);
            // 
            // receivetbx
            // 
            this.receivetbx.Location = new System.Drawing.Point(6, 42);
            this.receivetbx.Name = "receivetbx";
            this.receivetbx.Size = new System.Drawing.Size(775, 176);
            this.receivetbx.TabIndex = 4;
            this.receivetbx.Text = "";
            // 
            // recieveclearbtn
            // 
            this.recieveclearbtn.Location = new System.Drawing.Point(154, 15);
            this.recieveclearbtn.Name = "recieveclearbtn";
            this.recieveclearbtn.Size = new System.Drawing.Size(75, 23);
            this.recieveclearbtn.TabIndex = 3;
            this.recieveclearbtn.Text = "Clear";
            this.recieveclearbtn.UseVisualStyleBackColor = true;
            this.recieveclearbtn.Click += new System.EventHandler(this.recieveclearbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sendIntervalTimetbx);
            this.groupBox2.Controls.Add(this.autoSendcbx);
            this.groupBox2.Controls.Add(this.sendbtn);
            this.groupBox2.Controls.Add(this.sendclearbtn);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.sendtbx);
            this.groupBox2.Location = new System.Drawing.Point(88, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 224);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ms";
            // 
            // sendIntervalTimetbx
            // 
            this.sendIntervalTimetbx.Location = new System.Drawing.Point(326, 15);
            this.sendIntervalTimetbx.Name = "sendIntervalTimetbx";
            this.sendIntervalTimetbx.Size = new System.Drawing.Size(44, 23);
            this.sendIntervalTimetbx.TabIndex = 9;
            this.sendIntervalTimetbx.Text = "500";
            this.sendIntervalTimetbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // autoSendcbx
            // 
            this.autoSendcbx.AutoSize = true;
            this.autoSendcbx.Location = new System.Drawing.Point(235, 17);
            this.autoSendcbx.Name = "autoSendcbx";
            this.autoSendcbx.Size = new System.Drawing.Size(85, 19);
            this.autoSendcbx.TabIndex = 8;
            this.autoSendcbx.Text = "Auto Send";
            this.autoSendcbx.UseVisualStyleBackColor = true;
            this.autoSendcbx.CheckedChanged += new System.EventHandler(this.autoSendcbx_CheckedChanged);
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(706, 15);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 7;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // sendclearbtn
            // 
            this.sendclearbtn.Location = new System.Drawing.Point(154, 15);
            this.sendclearbtn.Name = "sendclearbtn";
            this.sendclearbtn.Size = new System.Drawing.Size(75, 23);
            this.sendclearbtn.TabIndex = 6;
            this.sendclearbtn.Text = "Clear";
            this.sendclearbtn.UseVisualStyleBackColor = true;
            this.sendclearbtn.Click += new System.EventHandler(this.sendclearbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sendStrRadiobtn);
            this.panel2.Controls.Add(this.sendHEXRadiobtn);
            this.panel2.Location = new System.Drawing.Point(6, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 23);
            this.panel2.TabIndex = 6;
            // 
            // sendStrRadiobtn
            // 
            this.sendStrRadiobtn.AutoSize = true;
            this.sendStrRadiobtn.Location = new System.Drawing.Point(9, 2);
            this.sendStrRadiobtn.Name = "sendStrRadiobtn";
            this.sendStrRadiobtn.Size = new System.Drawing.Size(58, 19);
            this.sendStrRadiobtn.TabIndex = 1;
            this.sendStrRadiobtn.TabStop = true;
            this.sendStrRadiobtn.Text = "String";
            this.sendStrRadiobtn.UseVisualStyleBackColor = true;
            this.sendStrRadiobtn.CheckedChanged += new System.EventHandler(this.sendStrRadiobtn_CheckedChanged);
            // 
            // sendHEXRadiobtn
            // 
            this.sendHEXRadiobtn.AutoSize = true;
            this.sendHEXRadiobtn.Checked = true;
            this.sendHEXRadiobtn.Location = new System.Drawing.Point(73, 2);
            this.sendHEXRadiobtn.Name = "sendHEXRadiobtn";
            this.sendHEXRadiobtn.Size = new System.Drawing.Size(47, 19);
            this.sendHEXRadiobtn.TabIndex = 2;
            this.sendHEXRadiobtn.TabStop = true;
            this.sendHEXRadiobtn.Text = "Hex";
            this.sendHEXRadiobtn.UseVisualStyleBackColor = true;
            this.sendHEXRadiobtn.CheckedChanged += new System.EventHandler(this.sendHEXRadiobtn_CheckedChanged);
            // 
            // sendtbx
            // 
            this.sendtbx.Location = new System.Drawing.Point(6, 42);
            this.sendtbx.Name = "sendtbx";
            this.sendtbx.Size = new System.Drawing.Size(775, 176);
            this.sendtbx.TabIndex = 5;
            this.sendtbx.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavetoolStripMenuItem,
            this.quitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // SavetoolStripMenuItem
            // 
            this.SavetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedDataToolStripMenuItem,
            this.sendDataToolStripMenuItem});
            this.SavetoolStripMenuItem.Name = "SavetoolStripMenuItem";
            this.SavetoolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.SavetoolStripMenuItem.Text = "Save";
            // 
            // receivedDataToolStripMenuItem
            // 
            this.receivedDataToolStripMenuItem.Name = "receivedDataToolStripMenuItem";
            this.receivedDataToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.receivedDataToolStripMenuItem.Text = "Save Receive Data";
            this.receivedDataToolStripMenuItem.Click += new System.EventHandler(this.receivedDataToolStripMenuItem_Click);
            // 
            // sendDataToolStripMenuItem
            // 
            this.sendDataToolStripMenuItem.Name = "sendDataToolStripMenuItem";
            this.sendDataToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sendDataToolStripMenuItem.Text = "Save Send Data";
            this.sendDataToolStripMenuItem.Click += new System.EventHandler(this.sendDataToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // statustimer
            // 
            this.statustimer.Enabled = true;
            this.statustimer.Interval = 1000;
            this.statustimer.Tick += new System.EventHandler(this.statustimer_Tick);
            // 
            // autoSendtimer
            // 
            this.autoSendtimer.Interval = 1000;
            this.autoSendtimer.Tick += new System.EventHandler(this.autoSendtimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Data Collecter";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox comListCbx;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox baudRateCbx;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox dataBitsCbx;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox stopBitsCbx;
        private System.Windows.Forms.ToolStripLabel Parity;
        private System.Windows.Forms.ToolStripComboBox parityCbx;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox handshakingcbx;
        private System.Windows.Forms.ToolStripButton openCloseSpbtn;
        private System.Windows.Forms.ToolStripButton refreshbtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusRx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTx;
        private System.Windows.Forms.ToolStripStatusLabel statusTimeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton recStrRadiobtn;
        private System.Windows.Forms.RadioButton recHEXRadiobtn;
        private System.Windows.Forms.RichTextBox receivetbx;
        private System.Windows.Forms.Button recieveclearbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Button sendclearbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton sendStrRadiobtn;
        private System.Windows.Forms.RadioButton sendHEXRadiobtn;
        private System.Windows.Forms.RichTextBox sendtbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer statustimer;
        private System.Windows.Forms.Timer autoSendtimer;
        private System.Windows.Forms.TextBox data2tbx;
        private System.Windows.Forms.TextBox data1tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem receivedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendDataToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sendIntervalTimetbx;
        private System.Windows.Forms.CheckBox autoSendcbx;
        private System.Windows.Forms.RadioButton CurrentSpeedSenseRadiobtn;
    }
}

