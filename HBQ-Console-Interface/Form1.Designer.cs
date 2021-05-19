namespace HBQ_Console_Interface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMenuName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTerminal = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExport = new HBQ_Console_Interface.CircleButton();
            this.btnClearConsole = new HBQ_Console_Interface.CircleButton();
            this.btnClearTerminal = new HBQ_Console_Interface.CircleButton();
            this.btnConnectPort = new HBQ_Console_Interface.CircleButton();
            this.circlePannel1 = new HBQ_Console_Interface.CirclePannel();
            this.label5 = new System.Windows.Forms.Label();
            this.pannelRX = new HBQ_Console_Interface.CirclePannel();
            this.pannelTX = new HBQ_Console_Interface.CirclePannel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbxStopBits = new HBQ_Console_Interface.CircleComboBox();
            this.cbxParity = new HBQ_Console_Interface.CircleComboBox();
            this.cbxDataBits = new HBQ_Console_Interface.CircleComboBox();
            this.cbxBaudRate = new HBQ_Console_Interface.CircleComboBox();
            this.cbxCOMPort = new HBQ_Console_Interface.CircleComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnConsole = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.circlePannel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 60);
            this.panel1.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1211, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "HBQ TECHNOLOGY";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1213, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 17);
            this.label18.TabIndex = 7;
            this.label18.Text = "www.hbqsolution.com";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.panel2.Controls.Add(this.btnConsole);
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.lbMenuName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 45);
            this.panel2.TabIndex = 1;
            // 
            // lbMenuName
            // 
            this.lbMenuName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuName.ForeColor = System.Drawing.Color.White;
            this.lbMenuName.Location = new System.Drawing.Point(0, 0);
            this.lbMenuName.Name = "lbMenuName";
            this.lbMenuName.Size = new System.Drawing.Size(245, 45);
            this.lbMenuName.TabIndex = 0;
            this.lbMenuName.Text = "Home";
            this.lbMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnConnectPort);
            this.panel3.Controls.Add(this.circlePannel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 648);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(250, 105);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1MinSize = 850;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1126, 648);
            this.splitContainer1.SplitterDistance = 873;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(868, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 648);
            this.panel7.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.txtConsole);
            this.splitContainer2.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.txtTerminal);
            this.splitContainer2.Panel2.Controls.Add(this.panel5);
            this.splitContainer2.Size = new System.Drawing.Size(247, 648);
            this.splitContainer2.SplitterDistance = 392;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.White;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Location = new System.Drawing.Point(0, 30);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(247, 362);
            this.txtConsole.TabIndex = 1;
            this.txtConsole.Text = "";
            this.txtConsole.WordWrap = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panel4.Controls.Add(this.btnExport);
            this.panel4.Controls.Add(this.btnClearConsole);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 30);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Console";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTerminal
            // 
            this.txtTerminal.BackColor = System.Drawing.Color.White;
            this.txtTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTerminal.Location = new System.Drawing.Point(0, 30);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.ReadOnly = true;
            this.txtTerminal.Size = new System.Drawing.Size(247, 220);
            this.txtTerminal.TabIndex = 2;
            this.txtTerminal.Text = "";
            this.txtTerminal.WordWrap = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panel5.Controls.Add(this.btnClearTerminal);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 30);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terminal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExport
            // 
            this.btnExport.BorderColor = System.Drawing.Color.Silver;
            this.btnExport.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(160, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(97)))), ((int)(((byte)(123)))));
            this.btnExport.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExport.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(230)))));
            this.btnExport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.BorderColor = System.Drawing.Color.Silver;
            this.btnClearConsole.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.btnClearConsole.FlatAppearance.BorderSize = 0;
            this.btnClearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearConsole.Location = new System.Drawing.Point(76, 3);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(97)))), ((int)(((byte)(123)))));
            this.btnClearConsole.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClearConsole.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(230)))));
            this.btnClearConsole.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClearConsole.Size = new System.Drawing.Size(75, 23);
            this.btnClearConsole.TabIndex = 1;
            this.btnClearConsole.Text = "Clear";
            this.btnClearConsole.TextColor = System.Drawing.Color.White;
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // btnClearTerminal
            // 
            this.btnClearTerminal.BorderColor = System.Drawing.Color.Silver;
            this.btnClearTerminal.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.btnClearTerminal.FlatAppearance.BorderSize = 0;
            this.btnClearTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTerminal.Location = new System.Drawing.Point(76, 4);
            this.btnClearTerminal.Name = "btnClearTerminal";
            this.btnClearTerminal.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(97)))), ((int)(((byte)(123)))));
            this.btnClearTerminal.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClearTerminal.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(230)))));
            this.btnClearTerminal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClearTerminal.Size = new System.Drawing.Size(75, 23);
            this.btnClearTerminal.TabIndex = 3;
            this.btnClearTerminal.Text = "Clear";
            this.btnClearTerminal.TextColor = System.Drawing.Color.White;
            this.btnClearTerminal.UseVisualStyleBackColor = true;
            this.btnClearTerminal.Click += new System.EventHandler(this.btnClearTerminal_Click);
            // 
            // btnConnectPort
            // 
            this.btnConnectPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectPort.BorderColor = System.Drawing.Color.Silver;
            this.btnConnectPort.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.btnConnectPort.FlatAppearance.BorderSize = 0;
            this.btnConnectPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectPort.Location = new System.Drawing.Point(10, 10);
            this.btnConnectPort.Name = "btnConnectPort";
            this.btnConnectPort.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(97)))), ((int)(((byte)(123)))));
            this.btnConnectPort.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnConnectPort.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(230)))));
            this.btnConnectPort.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConnectPort.Size = new System.Drawing.Size(225, 30);
            this.btnConnectPort.TabIndex = 2;
            this.btnConnectPort.Text = "Open Port";
            this.btnConnectPort.TextColor = System.Drawing.Color.White;
            this.btnConnectPort.UseVisualStyleBackColor = true;
            // 
            // circlePannel1
            // 
            this.circlePannel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circlePannel1.BackColor = System.Drawing.Color.Transparent;
            this.circlePannel1.Backround = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.circlePannel1.BorderColor = System.Drawing.Color.Gray;
            this.circlePannel1.BorderSize = 1;
            this.circlePannel1.Controls.Add(this.label5);
            this.circlePannel1.Controls.Add(this.pannelRX);
            this.circlePannel1.Controls.Add(this.pannelTX);
            this.circlePannel1.Controls.Add(this.panel9);
            this.circlePannel1.Controls.Add(this.cbxStopBits);
            this.circlePannel1.Controls.Add(this.cbxParity);
            this.circlePannel1.Controls.Add(this.cbxDataBits);
            this.circlePannel1.Controls.Add(this.cbxBaudRate);
            this.circlePannel1.Controls.Add(this.cbxCOMPort);
            this.circlePannel1.Controls.Add(this.label6);
            this.circlePannel1.Controls.Add(this.label3);
            this.circlePannel1.Controls.Add(this.label10);
            this.circlePannel1.Controls.Add(this.label9);
            this.circlePannel1.Controls.Add(this.label8);
            this.circlePannel1.Controls.Add(this.label7);
            this.circlePannel1.Controls.Add(this.label4);
            this.circlePannel1.Controls.Add(this.panel8);
            this.circlePannel1.Location = new System.Drawing.Point(5, 50);
            this.circlePannel1.Name = "circlePannel1";
            this.circlePannel1.PannelRadius = 10;
            this.circlePannel1.Size = new System.Drawing.Size(240, 588);
            this.circlePannel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(161, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "RX";
            // 
            // pannelRX
            // 
            this.pannelRX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pannelRX.Backround = System.Drawing.Color.Lime;
            this.pannelRX.BorderColor = System.Drawing.Color.Gray;
            this.pannelRX.BorderSize = 0;
            this.pannelRX.Location = new System.Drawing.Point(124, 550);
            this.pannelRX.Name = "pannelRX";
            this.pannelRX.PannelRadius = 15;
            this.pannelRX.Size = new System.Drawing.Size(30, 30);
            this.pannelRX.TabIndex = 13;
            // 
            // pannelTX
            // 
            this.pannelTX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pannelTX.Backround = System.Drawing.Color.Blue;
            this.pannelTX.BorderColor = System.Drawing.Color.Gray;
            this.pannelTX.BorderSize = 0;
            this.pannelTX.Location = new System.Drawing.Point(20, 550);
            this.pannelTX.Name = "pannelTX";
            this.pannelTX.PannelRadius = 15;
            this.pannelTX.Size = new System.Drawing.Size(30, 30);
            this.pannelTX.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(3, 537);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(230, 3);
            this.panel9.TabIndex = 11;
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxStopBits.BackColor = System.Drawing.Color.Transparent;
            this.cbxStopBits.Backround = System.Drawing.Color.White;
            this.cbxStopBits.BorderColor = System.Drawing.Color.Gray;
            this.cbxStopBits.BorderSize = 1;
            this.cbxStopBits.ComboBoxRadius = 5;
            this.cbxStopBits.ForeColor = System.Drawing.Color.Black;
            this.cbxStopBits.Location = new System.Drawing.Point(95, 187);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(135, 30);
            this.cbxStopBits.TabIndex = 10;
            this.cbxStopBits.Text = "circleComboBox1";
            // 
            // cbxParity
            // 
            this.cbxParity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxParity.BackColor = System.Drawing.Color.Transparent;
            this.cbxParity.Backround = System.Drawing.Color.White;
            this.cbxParity.BorderColor = System.Drawing.Color.Gray;
            this.cbxParity.BorderSize = 1;
            this.cbxParity.ComboBoxRadius = 5;
            this.cbxParity.ForeColor = System.Drawing.Color.Black;
            this.cbxParity.Location = new System.Drawing.Point(95, 153);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(135, 30);
            this.cbxParity.TabIndex = 10;
            this.cbxParity.Text = "circleComboBox1";
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDataBits.BackColor = System.Drawing.Color.Transparent;
            this.cbxDataBits.Backround = System.Drawing.Color.White;
            this.cbxDataBits.BorderColor = System.Drawing.Color.Gray;
            this.cbxDataBits.BorderSize = 1;
            this.cbxDataBits.ComboBoxRadius = 5;
            this.cbxDataBits.ForeColor = System.Drawing.Color.Black;
            this.cbxDataBits.Location = new System.Drawing.Point(95, 119);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(135, 30);
            this.cbxDataBits.TabIndex = 10;
            this.cbxDataBits.Text = "circleComboBox1";
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBaudRate.BackColor = System.Drawing.Color.Transparent;
            this.cbxBaudRate.Backround = System.Drawing.Color.White;
            this.cbxBaudRate.BorderColor = System.Drawing.Color.Gray;
            this.cbxBaudRate.BorderSize = 1;
            this.cbxBaudRate.ComboBoxRadius = 5;
            this.cbxBaudRate.ForeColor = System.Drawing.Color.Black;
            this.cbxBaudRate.Location = new System.Drawing.Point(95, 85);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(135, 30);
            this.cbxBaudRate.TabIndex = 10;
            this.cbxBaudRate.Text = "circleComboBox1";
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCOMPort.BackColor = System.Drawing.Color.Transparent;
            this.cbxCOMPort.Backround = System.Drawing.Color.White;
            this.cbxCOMPort.BorderColor = System.Drawing.Color.Gray;
            this.cbxCOMPort.BorderSize = 1;
            this.cbxCOMPort.ComboBoxRadius = 5;
            this.cbxCOMPort.ForeColor = System.Drawing.Color.Black;
            this.cbxCOMPort.Location = new System.Drawing.Point(95, 50);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(135, 30);
            this.cbxCOMPort.TabIndex = 10;
            this.cbxCOMPort.Text = "circleComboBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Port";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Stop bits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Data bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Parity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Baudrate";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "UART Configuration";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(5, 33);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(230, 3);
            this.panel8.TabIndex = 3;
            // 
            // btnConsole
            // 
            this.btnConsole.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsole.FlatAppearance.BorderSize = 0;
            this.btnConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsole.Image = global::HBQ_Console_Interface.Properties.Resources.test;
            this.btnConsole.Location = new System.Drawing.Point(365, 0);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(60, 45);
            this.btnConsole.TabIndex = 3;
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Image = global::HBQ_Console_Interface.Properties.Resources.settings;
            this.btnConfig.Location = new System.Drawing.Point(305, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(60, 45);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::HBQ_Console_Interface.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(245, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::HBQ_Console_Interface.Properties.Resources.water_mark_HBQ_1;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 60);
            this.panel6.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1376, 753);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.circlePannel1.ResumeLayout(false);
            this.circlePannel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CirclePannel circlePannel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel4;
        private CircleButton btnClearConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private CircleButton btnClearTerminal;
        private System.Windows.Forms.Label label2;
        private CircleButton btnConnectPort;
        private CircleComboBox cbxStopBits;
        private CircleComboBox cbxParity;
        private CircleComboBox cbxDataBits;
        private CircleComboBox cbxBaudRate;
        private CircleComboBox cbxCOMPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.RichTextBox txtTerminal;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbMenuName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private CirclePannel pannelRX;
        private CirclePannel pannelTX;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private CircleButton btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

