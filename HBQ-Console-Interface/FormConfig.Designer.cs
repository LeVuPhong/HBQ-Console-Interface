namespace HBQ_Console_Interface
{
    partial class FormConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.btnWriteAll = new System.Windows.Forms.Button();
            this.btnSetDefault = new System.Windows.Forms.Button();
            this.btnsaveFlash = new System.Windows.Forms.Button();
            this.pn26 = new System.Windows.Forms.Panel();
            this.configItemBattery = new HBQ_Console_Interface.CommandItem2();
            this.configItemGSM = new HBQ_Console_Interface.CommandItem1();
            this.configItemServer = new HBQ_Console_Interface.CommandItem2();
            this.configItemLogging = new HBQ_Console_Interface.CommandItem1();
            this.configItemSamplingSendding = new HBQ_Console_Interface.CommandItem2();
            this.configItemDeviceID = new HBQ_Console_Interface.CommandItem2();
            this.configItemSerialID = new HBQ_Console_Interface.CommandItem2();
            this.panel1.SuspendLayout();
            this.pn26.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReadAll);
            this.panel1.Controls.Add(this.btnWriteAll);
            this.panel1.Controls.Add(this.btnSetDefault);
            this.panel1.Controls.Add(this.btnsaveFlash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnReadAll
            // 
            this.btnReadAll.FlatAppearance.BorderSize = 0;
            this.btnReadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadAll.Image = global::HBQ_Console_Interface.Properties.Resources.read_all;
            this.btnReadAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReadAll.Location = new System.Drawing.Point(284, 12);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(117, 82);
            this.btnReadAll.TabIndex = 3;
            this.btnReadAll.Text = "Read All";
            this.btnReadAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReadAll.UseVisualStyleBackColor = true;
            // 
            // btnWriteAll
            // 
            this.btnWriteAll.FlatAppearance.BorderSize = 0;
            this.btnWriteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteAll.Image = global::HBQ_Console_Interface.Properties.Resources.dafault48;
            this.btnWriteAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWriteAll.Location = new System.Drawing.Point(407, 12);
            this.btnWriteAll.Name = "btnWriteAll";
            this.btnWriteAll.Size = new System.Drawing.Size(128, 82);
            this.btnWriteAll.TabIndex = 2;
            this.btnWriteAll.Text = "Write All";
            this.btnWriteAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWriteAll.UseVisualStyleBackColor = true;
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.FlatAppearance.BorderSize = 0;
            this.btnSetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDefault.Image = global::HBQ_Console_Interface.Properties.Resources.dafault48;
            this.btnSetDefault.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetDefault.Location = new System.Drawing.Point(135, 12);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(143, 82);
            this.btnSetDefault.TabIndex = 1;
            this.btnSetDefault.Text = "Default Setting";
            this.btnSetDefault.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetDefault.UseVisualStyleBackColor = true;
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // btnsaveFlash
            // 
            this.btnsaveFlash.FlatAppearance.BorderSize = 0;
            this.btnsaveFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveFlash.Image = global::HBQ_Console_Interface.Properties.Resources.save48;
            this.btnsaveFlash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsaveFlash.Location = new System.Drawing.Point(12, 12);
            this.btnsaveFlash.Name = "btnsaveFlash";
            this.btnsaveFlash.Size = new System.Drawing.Size(117, 82);
            this.btnsaveFlash.TabIndex = 0;
            this.btnsaveFlash.Text = "Save Flash";
            this.btnsaveFlash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsaveFlash.UseVisualStyleBackColor = true;
            this.btnsaveFlash.Click += new System.EventHandler(this.btnsaveFlash_Click);
            // 
            // pn26
            // 
            this.pn26.AutoScroll = true;
            this.pn26.Controls.Add(this.configItemBattery);
            this.pn26.Controls.Add(this.configItemGSM);
            this.pn26.Controls.Add(this.configItemServer);
            this.pn26.Controls.Add(this.configItemLogging);
            this.pn26.Controls.Add(this.configItemSamplingSendding);
            this.pn26.Controls.Add(this.configItemDeviceID);
            this.pn26.Controls.Add(this.configItemSerialID);
            this.pn26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn26.Location = new System.Drawing.Point(0, 100);
            this.pn26.Name = "pn26";
            this.pn26.Size = new System.Drawing.Size(1000, 528);
            this.pn26.TabIndex = 1;
            this.pn26.Paint += new System.Windows.Forms.PaintEventHandler(this.pn26_Paint);
            // 
            // configItemBattery
            // 
            this.configItemBattery.ButtonReadVisible = true;
            this.configItemBattery.ButtonWriteEnable = false;
            this.configItemBattery.ButtonWriteVisible = true;
            this.configItemBattery.Dock = System.Windows.Forms.DockStyle.Top;
            this.configItemBattery.ItemAutoSize = HBQ_Console_Interface.ConfigItem2AutoSize.Both;
            this.configItemBattery.ItemShow = HBQ_Console_Interface.ConfigItem2Show.Both;
            this.configItemBattery.ItemText = "Battery Coff";
            this.configItemBattery.LabelShow = HBQ_Console_Interface.ConfigItem2LabelShow.Both;
            this.configItemBattery.LabelSize1 = 80;
            this.configItemBattery.LabelSize2 = 80;
            this.configItemBattery.LabelText1 = "Main";
            this.configItemBattery.LabelText2 = "Secondary";
            this.configItemBattery.Location = new System.Drawing.Point(0, 270);
            this.configItemBattery.MessageIcon = HBQ_Console_Interface.ConfigMessageIconEnum.Ok;
            this.configItemBattery.MessageText = "Write OK!";
            this.configItemBattery.MessageVisible = true;
            this.configItemBattery.Name = "configItemBattery";
            this.configItemBattery.PanelMessageSize = 300;
            this.configItemBattery.Size = new System.Drawing.Size(1000, 45);
            this.configItemBattery.TabIndex = 6;
            this.configItemBattery.Text1 = "";
            this.configItemBattery.Text2 = "";
            this.configItemBattery.TextBox1Size = 225;
            this.configItemBattery.TextBox1ValueType = HBQ_Console_Interface.TextBoxValueType.String;
            this.configItemBattery.TextBox2Size = 225;
            this.configItemBattery.TextBox2ValueType = HBQ_Console_Interface.TextBoxValueType.String;
            this.configItemBattery.ButtonReadClick += new System.EventHandler(this.configItemBattery_ButtonReadClick);
            this.configItemBattery.ButtonWriteClick += new System.EventHandler(this.configItemBattery_ButtonWriteClick);
            // 
            // configItemGSM
            // 
            this.configItemGSM.BackColor = System.Drawing.Color.White;
            this.configItemGSM.ButtonReadVisible = true;
            this.configItemGSM.ButtonWriteEnable = false;
            this.configItemGSM.ButtonWriteVisible = true;
            this.configItemGSM.ComboBoxSize = 450;
            this.configItemGSM.Dock = System.Windows.Forms.DockStyle.Top;
            this.configItemGSM.ItemAutoSize = HBQ_Console_Interface.ConfigItem1AutoSize.ComboBox1;
            this.configItemGSM.ItemShow = HBQ_Console_Interface.ConfigItem1Show.ComboBox1;
            this.configItemGSM.ItemText = "GSM Servicer";
            this.configItemGSM.LabelShow = HBQ_Console_Interface.ConfigItem1LabelShow.HideAll;
            this.configItemGSM.LabelSize1 = 75;
            this.configItemGSM.LabelSize2 = 75;
            this.configItemGSM.LabelText1 = "Text1";
            this.configItemGSM.LabelText2 = "Text2";
            this.configItemGSM.Location = new System.Drawing.Point(0, 225);
            this.configItemGSM.MessageIcon = HBQ_Console_Interface.ConfigMessageIconEnum.Ok;
            this.configItemGSM.MessageText = "Write OK!";
            this.configItemGSM.MessageVisible = true;
            this.configItemGSM.Name = "configItemGSM";
            this.configItemGSM.PanelMessageSize = 300;
            this.configItemGSM.SelectedIndex = -1;
            this.configItemGSM.Size = new System.Drawing.Size(1000, 45);
            this.configItemGSM.TabIndex = 5;
            this.configItemGSM.Text1 = "";
            this.configItemGSM.TextBoxSize = 225;
            this.configItemGSM.ButtonReadClick += new System.EventHandler(this.configItemGSM_ButtonReadClick);
            this.configItemGSM.ButtonWriteClick += new System.EventHandler(this.configItemGSM_ButtonWriteClick);
            // 
            // configItemServer
            // 
            this.configItemServer.ButtonReadVisible = true;
            this.configItemServer.ButtonWriteEnable = false;
            this.configItemServer.ButtonWriteVisible = true;
            this.configItemServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.configItemServer.ItemAutoSize = HBQ_Console_Interface.ConfigItem2AutoSize.TextBox2;
            this.configItemServer.ItemShow = HBQ_Console_Interface.ConfigItem2Show.Both;
            this.configItemServer.ItemText = "Server DAQ";
            this.configItemServer.LabelShow = HBQ_Console_Interface.ConfigItem2LabelShow.OnlyLabel1;
            this.configItemServer.LabelSize1 = 40;
            this.configItemServer.LabelSize2 = 75;
            this.configItemServer.LabelText1 = "Port";
            this.configItemServer.LabelText2 = "Text2";
            this.configItemServer.Location = new System.Drawing.Point(0, 180);
            this.configItemServer.MessageIcon = HBQ_Console_Interface.ConfigMessageIconEnum.Ok;
            this.configItemServer.MessageText = "Write OK!";
            this.configItemServer.MessageVisible = true;
            this.configItemServer.Name = "configItemServer";
            this.configItemServer.PanelMessageSize = 300;
            this.configItemServer.Size = new System.Drawing.Size(1000, 45);
            this.configItemServer.TabIndex = 4;
            this.configItemServer.Text1 = "";
            this.configItemServer.Text2 = "";
            this.configItemServer.TextBox1Size = 100;
            this.configItemServer.TextBox1ValueType = HBQ_Console_Interface.TextBoxValueType.String;
            this.configItemServer.TextBox2Size = 350;
            this.configItemServer.TextBox2ValueType = HBQ_Console_Interface.TextBoxValueType.String;
            this.configItemServer.ButtonReadClick += new System.EventHandler(this.configItemServer_ButtonReadClick);
            this.configItemServer.ButtonWriteClick += new System.EventHandler(this.configItemServer_ButtonWriteClick);
            // 
            // configItemLogging
            // 
            this.configItemLogging.BackColor = System.Drawing.Color.White;
            this.configItemLogging.ButtonReadVisible = true;
            this.configItemLogging.ButtonWriteEnable = false;
            this.configItemLogging.ButtonWriteVisible = true;
            this.configItemLogging.ComboBoxSize = 350;
            this.configItemLogging.Dock = System.Windows.Forms.DockStyle.Top;
            this.configItemLogging.ItemAutoSize = HBQ_Console_Interface.ConfigItem1AutoSize.ComboBox1;
            this.configItemLogging.ItemShow = HBQ_Console_Interface.ConfigItem1Show.Both;
            this.configItemLogging.ItemText = "Logging Mode";
            this.configItemLogging.LabelShow = HBQ_Console_Interface.ConfigItem1LabelShow.HideAll;
            this.configItemLogging.LabelSize1 = 40;
            this.configItemLogging.LabelSize2 = 75;
            this.configItemLogging.LabelText1 = "Port";
            this.configItemLogging.LabelText2 = "Text2";
            this.configItemLogging.Location = new System.Drawing.Point(0, 135);
            this.configItemLogging.MessageIcon = HBQ_Console_Interface.ConfigMessageIconEnum.Ok;
            this.configItemLogging.MessageText = "Write OK!";
            this.configItemLogging.MessageVisible = true;
            this.configItemLogging.Name = "configItemLogging";
            this.configItemLogging.PanelMessageSize = 300;
            this.configItemLogging.SelectedIndex = -1;
            this.configItemLogging.Size = new System.Drawing.Size(1000, 45);
            this.configItemLogging.TabIndex = 3;
            this.configItemLogging.Text1 = "";
            this.configItemLogging.TextBoxSize = 100;
            this.configItemLogging.ButtonReadClick += new System.EventHandler(this.configItemLogging_ButtonReadClick);
            this.configItemLogging.ButtonWriteClick += new System.EventHandler(this.configItemLogging_ButtonWriteClick);
            // 
            // configItemSamplingSendding
            // 
            this.configItemSamplingSendding.ButtonReadVisible = true;
            this.configItemSamplingSendding.ButtonWriteEnable = false;
            this.configItemSamplingSendding.ButtonWriteVisible = true;
            this.configItemSamplingSendding.Dock = System.Windows.Forms.DockStyle.Top;
            this.configItemSamplingSendding.ItemAutoSize = HBQ_Console_Interface.ConfigItem2AutoSize.Both;
            this.configItemSamplingSendding.ItemShow = HBQ_Console_Interface.ConfigItem2Show.Both;
            this.configItemSamplingSendding.ItemText = "Sampling Rate / Sending Rate";
            this.configItemSamplingSendding.LabelShow = HBQ_Console_Interface.ConfigItem2LabelShow.Both;
            this.configItemSamplingSendding.LabelSize1 = 75;
            this.configItemSamplingSendding.LabelSize2 = 75;
            this.configItemSamplingSendding.LabelText1 = "x1 min";
            this.configItemSamplingSendding.LabelText2 = "x1 min";
            this.configItemSamplingSendding.Location = new System.Drawing.Point(0, 90);
            this.configItemSamplingSendding.MessageIcon = HBQ_Console_Interface.ConfigMessageIconEnum.Ok;
            this.configItemSamplingSendding.MessageText = "Write OK!";
            this.configItemSamplingSendding.MessageVisible = true;
            this.configItemSamplingSendding.Name = "configItemSamplingSendding";
            this.configItemSamplingSendding.PanelMessageSize = 300;
            this.configItemSamplingSendding.Size = new System.Drawing.Size(1000, 45);
            this.configItemSamplingSendding.TabIndex = 2;
            this.configItemSamplingSendding.Text1 = "";
            this.configItemSamplingSendding.Text2 = "";
            this.configItemSamplingSendding.TextBox1Size = 225;
            this.configItemSamplingSendding.TextBox1ValueType = HBQ_Console_Interface.TextBoxValueType.Number;
            this.configItemSamplingSendding.TextBox2Size = 225;
            this.configItemSamplingSendding.TextBox2ValueType = HBQ_Console_Interface.TextBoxValueType.Number;
            this.configItemSamplingSendding.ButtonReadClick += new System.EventHandler(this.configItemSamplingSendding_ButtonReadClick);
            this.configItemSamplingSendding.ButtonWriteClick += new System.EventHandler(this.configItemSamplingSendding_ButtonWriteClick);
            // 
            // configItemDeviceID
            // 
            this.configItemDeviceID.ButtonReadVisible = true;
            this.configItemDeviceID.ButtonWriteEnable = false;
            this.configItemDeviceID.ButtonWriteVisible = true;
            this.configItemDeviceID.Dock = System.Windows.Forms.DockStyle.Top;
            this.configItemDeviceID.ItemAutoSize = HBQ_Console_Interface.ConfigItem2AutoSize.TextBox1;
            this.configItemDeviceID.ItemShow = HBQ_Console_Interface.ConfigItem2Show.TextBox1;
            this.configItemDeviceID.ItemText = "Device ID";
            this.configItemDeviceID.LabelShow = HBQ_Console_Interface.ConfigItem2LabelShow.HideAll;
            this.configItemDeviceID.LabelSize1 = 75;
            this.configItemDeviceID.LabelSize2 = 75;
            this.configItemDeviceID.LabelText1 = "Text1";
            this.configItemDeviceID.LabelText2 = "Text2";
            this.configItemDeviceID.Location = new System.Drawing.Point(0, 45);
            this.configItemDeviceID.MessageIcon = HBQ_Console_Interface.ConfigMessageIconEnum.Ok;
            this.configItemDeviceID.MessageText = "Write OK!";
            this.configItemDeviceID.MessageVisible = true;
            this.configItemDeviceID.Name = "configItemDeviceID";
            this.configItemDeviceID.PanelMessageSize = 300;
            this.configItemDeviceID.Size = new System.Drawing.Size(1000, 45);
            this.configItemDeviceID.TabIndex = 1;
            this.configItemDeviceID.Text1 = "";
            this.configItemDeviceID.Text2 = "";
            this.configItemDeviceID.TextBox1Size = 450;
            this.configItemDeviceID.TextBox1ValueType = HBQ_Console_Interface.TextBoxValueType.String;
            this.configItemDeviceID.TextBox2Size = 225;
            this.configItemDeviceID.TextBox2ValueType = HBQ_Console_Interface.TextBoxValueType.String;
            this.configItemDeviceID.ButtonReadClick += new System.EventHandler(this.configItemDeviceID_ButtonReadClick);
            this.configItemDeviceID.ButtonWriteClick += new System.EventHandler(this.configItemDeviceID_ButtonWriteClick);
            // 
            // configItemSerialID
            // 
            this.configItemSerialID.ButtonReadVisible = true;
            this.configItemSerialID.ButtonWriteEnable = false;
            this.configItemSerialID.ButtonWriteVisible = true;
            this.configItemSerialID.Dock = System.Windows.Forms.DockStyle.Top;
            this.configItemSerialID.ItemAutoSize = HBQ_Console_Interface.ConfigItem2AutoSize.TextBox1;
            this.configItemSerialID.ItemShow = HBQ_Console_Interface.ConfigItem2Show.TextBox1;
            this.configItemSerialID.ItemText = "Serial ID";
            this.configItemSerialID.LabelShow = HBQ_Console_Interface.ConfigItem2LabelShow.HideAll;
            this.configItemSerialID.LabelSize1 = 75;
            this.configItemSerialID.LabelSize2 = 75;
            this.configItemSerialID.LabelText1 = "Text1";
            this.configItemSerialID.LabelText2 = "Text2";
            this.configItemSerialID.Location = new System.Drawing.Point(0, 0);
            this.configItemSerialID.MessageIcon = HBQ_Console_Interface.ConfigMessageIconEnum.Ok;
            this.configItemSerialID.MessageText = "Write OK!";
            this.configItemSerialID.MessageVisible = true;
            this.configItemSerialID.Name = "configItemSerialID";
            this.configItemSerialID.PanelMessageSize = 300;
            this.configItemSerialID.Size = new System.Drawing.Size(1000, 45);
            this.configItemSerialID.TabIndex = 0;
            this.configItemSerialID.Text1 = "";
            this.configItemSerialID.Text2 = "";
            this.configItemSerialID.TextBox1Size = 450;
            this.configItemSerialID.TextBox1ValueType = HBQ_Console_Interface.TextBoxValueType.String;
            this.configItemSerialID.TextBox2Size = 225;
            this.configItemSerialID.TextBox2ValueType = HBQ_Console_Interface.TextBoxValueType.String;
            this.configItemSerialID.ButtonReadClick += new System.EventHandler(this.configItemSerialID_ButtonReadClick);
            this.configItemSerialID.ButtonWriteClick += new System.EventHandler(this.configItemSerialID_ButtonWriteClick);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 628);
            this.Controls.Add(this.pn26);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.pn26.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn26;
        private System.Windows.Forms.Button btnSetDefault;
        private System.Windows.Forms.Button btnsaveFlash;
        public CommandItem2 configItemBattery;
        public CommandItem1 configItemGSM;
        public CommandItem2 configItemServer;
        public CommandItem1 configItemLogging;
        public CommandItem2 configItemSamplingSendding;
        public CommandItem2 configItemDeviceID;
        public CommandItem2 configItemSerialID;
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.Button btnWriteAll;
    }
}