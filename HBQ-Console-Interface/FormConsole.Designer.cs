namespace HBQ_Console_Interface
{
    partial class FormConsole
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.testReadFlash = new HBQ_Console_Interface.TestItem();
            this.testEraseFlash = new HBQ_Console_Interface.TestItem();
            this.testPerformance = new HBQ_Console_Interface.TestItem();
            this.testFlowSensor = new HBQ_Console_Interface.TestItem();
            this.testVSensor = new HBQ_Console_Interface.TestItem();
            this.testPulse = new HBQ_Console_Interface.TestItem();
            this.testSDCard = new HBQ_Console_Interface.TestItem();
            this.testGPRS = new HBQ_Console_Interface.TestItem();
            this.testPower = new HBQ_Console_Interface.TestItem();
            this.testGSM = new HBQ_Console_Interface.TestItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportTestConsole = new HBQ_Console_Interface.CircleButton();
            this.btnClearTestConsole = new HBQ_Console_Interface.CircleButton();
            this.txtTestConsole = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.testReadFlash);
            this.panel2.Controls.Add(this.testEraseFlash);
            this.panel2.Controls.Add(this.testPerformance);
            this.panel2.Controls.Add(this.testFlowSensor);
            this.panel2.Controls.Add(this.testVSensor);
            this.panel2.Controls.Add(this.testPulse);
            this.panel2.Controls.Add(this.testSDCard);
            this.panel2.Controls.Add(this.testGPRS);
            this.panel2.Controls.Add(this.testPower);
            this.panel2.Controls.Add(this.testGSM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 723);
            this.panel2.TabIndex = 1;
            // 
            // testReadFlash
            // 
            this.testReadFlash.BackColor = System.Drawing.Color.Transparent;
            this.testReadFlash.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testReadFlash.Cycle = 1;
            this.testReadFlash.CycleEnable = true;
            this.testReadFlash.CycleVisible = false;
            this.testReadFlash.Dock = System.Windows.Forms.DockStyle.Top;
            this.testReadFlash.ItemShow = HBQ_Console_Interface.TestItemShow.Numberic;
            this.testReadFlash.Location = new System.Drawing.Point(0, 405);
            this.testReadFlash.Message = "Message";
            this.testReadFlash.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testReadFlash.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testReadFlash.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testReadFlash.MessageSize = 50;
            this.testReadFlash.MessageVisible = false;
            this.testReadFlash.Name = "testReadFlash";
            this.testReadFlash.Size = new System.Drawing.Size(500, 45);
            this.testReadFlash.TabIndex = 9;
            this.testReadFlash.Text = "testItem10";
            this.testReadFlash.Title = "READ EXTERNAL FLASH";
            this.testReadFlash.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testReadFlash.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testReadFlash.TitleForeColor = System.Drawing.Color.White;
            this.testReadFlash.TitleSize = 300;
            this.testReadFlash.ButtonClick += new System.EventHandler(this.testReadFlash_ButtonClick);
            // 
            // testEraseFlash
            // 
            this.testEraseFlash.BackColor = System.Drawing.Color.Transparent;
            this.testEraseFlash.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testEraseFlash.Cycle = 1;
            this.testEraseFlash.CycleEnable = true;
            this.testEraseFlash.CycleVisible = false;
            this.testEraseFlash.Dock = System.Windows.Forms.DockStyle.Top;
            this.testEraseFlash.ItemShow = HBQ_Console_Interface.TestItemShow.Numberic;
            this.testEraseFlash.Location = new System.Drawing.Point(0, 360);
            this.testEraseFlash.Message = "Message";
            this.testEraseFlash.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testEraseFlash.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testEraseFlash.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testEraseFlash.MessageSize = 50;
            this.testEraseFlash.MessageVisible = false;
            this.testEraseFlash.Name = "testEraseFlash";
            this.testEraseFlash.Size = new System.Drawing.Size(500, 45);
            this.testEraseFlash.TabIndex = 8;
            this.testEraseFlash.Text = "testItem9";
            this.testEraseFlash.Title = "ERASE EXTERNAL FLASH";
            this.testEraseFlash.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testEraseFlash.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testEraseFlash.TitleForeColor = System.Drawing.Color.White;
            this.testEraseFlash.TitleSize = 300;
            this.testEraseFlash.ButtonClick += new System.EventHandler(this.testEraseFlash_ButtonClick);
            // 
            // testPerformance
            // 
            this.testPerformance.BackColor = System.Drawing.Color.Transparent;
            this.testPerformance.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testPerformance.Cycle = 1;
            this.testPerformance.CycleEnable = true;
            this.testPerformance.CycleVisible = true;
            this.testPerformance.Dock = System.Windows.Forms.DockStyle.Top;
            this.testPerformance.ItemShow = HBQ_Console_Interface.TestItemShow.ComboBox;
            this.testPerformance.Location = new System.Drawing.Point(0, 315);
            this.testPerformance.Message = "Message";
            this.testPerformance.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testPerformance.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testPerformance.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testPerformance.MessageSize = 50;
            this.testPerformance.MessageVisible = false;
            this.testPerformance.Name = "testPerformance";
            this.testPerformance.Size = new System.Drawing.Size(500, 45);
            this.testPerformance.TabIndex = 7;
            this.testPerformance.Text = "testItem8";
            this.testPerformance.Title = "TEST PERFORMANCE";
            this.testPerformance.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testPerformance.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testPerformance.TitleForeColor = System.Drawing.Color.White;
            this.testPerformance.TitleSize = 300;
            this.testPerformance.ButtonClick += new System.EventHandler(this.testPerformance_ButtonClick);
            // 
            // testFlowSensor
            // 
            this.testFlowSensor.BackColor = System.Drawing.Color.Transparent;
            this.testFlowSensor.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testFlowSensor.Cycle = 1;
            this.testFlowSensor.CycleEnable = false;
            this.testFlowSensor.CycleVisible = false;
            this.testFlowSensor.Dock = System.Windows.Forms.DockStyle.Top;
            this.testFlowSensor.ItemShow = HBQ_Console_Interface.TestItemShow.Numberic;
            this.testFlowSensor.Location = new System.Drawing.Point(0, 270);
            this.testFlowSensor.Message = "Message";
            this.testFlowSensor.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testFlowSensor.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testFlowSensor.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testFlowSensor.MessageSize = 50;
            this.testFlowSensor.MessageVisible = false;
            this.testFlowSensor.Name = "testFlowSensor";
            this.testFlowSensor.Size = new System.Drawing.Size(500, 45);
            this.testFlowSensor.TabIndex = 6;
            this.testFlowSensor.Text = "testItem7";
            this.testFlowSensor.Title = "TEST FLOW SENSOR";
            this.testFlowSensor.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testFlowSensor.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testFlowSensor.TitleForeColor = System.Drawing.Color.White;
            this.testFlowSensor.TitleSize = 300;
            this.testFlowSensor.ButtonClick += new System.EventHandler(this.testFlowSensor_ButtonClick);
            // 
            // testVSensor
            // 
            this.testVSensor.BackColor = System.Drawing.Color.Transparent;
            this.testVSensor.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testVSensor.Cycle = 1;
            this.testVSensor.CycleEnable = true;
            this.testVSensor.CycleVisible = true;
            this.testVSensor.Dock = System.Windows.Forms.DockStyle.Top;
            this.testVSensor.ItemShow = HBQ_Console_Interface.TestItemShow.ComboBox;
            this.testVSensor.Location = new System.Drawing.Point(0, 225);
            this.testVSensor.Message = "Message";
            this.testVSensor.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testVSensor.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testVSensor.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testVSensor.MessageSize = 50;
            this.testVSensor.MessageVisible = false;
            this.testVSensor.Name = "testVSensor";
            this.testVSensor.Size = new System.Drawing.Size(500, 45);
            this.testVSensor.TabIndex = 5;
            this.testVSensor.Text = "testItem6";
            this.testVSensor.Title = "TEST V SENSOR OUT";
            this.testVSensor.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testVSensor.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testVSensor.TitleForeColor = System.Drawing.Color.White;
            this.testVSensor.TitleSize = 300;
            this.testVSensor.ButtonClick += new System.EventHandler(this.testVSensor_ButtonClick);
            // 
            // testPulse
            // 
            this.testPulse.BackColor = System.Drawing.Color.Transparent;
            this.testPulse.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testPulse.Cycle = 1;
            this.testPulse.CycleEnable = true;
            this.testPulse.CycleVisible = true;
            this.testPulse.Dock = System.Windows.Forms.DockStyle.Top;
            this.testPulse.ItemShow = HBQ_Console_Interface.TestItemShow.Numberic;
            this.testPulse.Location = new System.Drawing.Point(0, 180);
            this.testPulse.Message = "Message";
            this.testPulse.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testPulse.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testPulse.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testPulse.MessageSize = 50;
            this.testPulse.MessageVisible = false;
            this.testPulse.Name = "testPulse";
            this.testPulse.Size = new System.Drawing.Size(500, 45);
            this.testPulse.TabIndex = 4;
            this.testPulse.Text = "testItem5";
            this.testPulse.Title = "TEST PULSE IN";
            this.testPulse.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testPulse.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testPulse.TitleForeColor = System.Drawing.Color.White;
            this.testPulse.TitleSize = 300;
            this.testPulse.ButtonClick += new System.EventHandler(this.testPulse_ButtonClick);
            // 
            // testSDCard
            // 
            this.testSDCard.BackColor = System.Drawing.Color.Transparent;
            this.testSDCard.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testSDCard.Cycle = 1;
            this.testSDCard.CycleEnable = false;
            this.testSDCard.CycleVisible = false;
            this.testSDCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.testSDCard.ItemShow = HBQ_Console_Interface.TestItemShow.Numberic;
            this.testSDCard.Location = new System.Drawing.Point(0, 135);
            this.testSDCard.Message = "Message";
            this.testSDCard.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testSDCard.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testSDCard.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testSDCard.MessageSize = 50;
            this.testSDCard.MessageVisible = false;
            this.testSDCard.Name = "testSDCard";
            this.testSDCard.Size = new System.Drawing.Size(500, 45);
            this.testSDCard.TabIndex = 3;
            this.testSDCard.Text = "testItem4";
            this.testSDCard.Title = "TEST SD CARD";
            this.testSDCard.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testSDCard.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testSDCard.TitleForeColor = System.Drawing.Color.White;
            this.testSDCard.TitleSize = 300;
            this.testSDCard.ButtonClick += new System.EventHandler(this.testSDCard_ButtonClick);
            // 
            // testGPRS
            // 
            this.testGPRS.BackColor = System.Drawing.Color.Transparent;
            this.testGPRS.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testGPRS.Cycle = 1;
            this.testGPRS.CycleEnable = true;
            this.testGPRS.CycleVisible = false;
            this.testGPRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.testGPRS.ItemShow = HBQ_Console_Interface.TestItemShow.Numberic;
            this.testGPRS.Location = new System.Drawing.Point(0, 90);
            this.testGPRS.Message = "Message";
            this.testGPRS.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testGPRS.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testGPRS.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testGPRS.MessageSize = 50;
            this.testGPRS.MessageVisible = false;
            this.testGPRS.Name = "testGPRS";
            this.testGPRS.Size = new System.Drawing.Size(500, 45);
            this.testGPRS.TabIndex = 2;
            this.testGPRS.Text = "testItem3";
            this.testGPRS.Title = "TEST GPRS / 3G";
            this.testGPRS.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testGPRS.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testGPRS.TitleForeColor = System.Drawing.Color.White;
            this.testGPRS.TitleSize = 300;
            this.testGPRS.ButtonClick += new System.EventHandler(this.testGPRS_ButtonClick);
            // 
            // testPower
            // 
            this.testPower.BackColor = System.Drawing.Color.Transparent;
            this.testPower.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testPower.Cycle = 1;
            this.testPower.CycleEnable = true;
            this.testPower.CycleVisible = true;
            this.testPower.Dock = System.Windows.Forms.DockStyle.Top;
            this.testPower.ItemShow = HBQ_Console_Interface.TestItemShow.Numberic;
            this.testPower.Location = new System.Drawing.Point(0, 45);
            this.testPower.Message = "Message";
            this.testPower.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testPower.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testPower.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testPower.MessageSize = 50;
            this.testPower.MessageVisible = false;
            this.testPower.Name = "testPower";
            this.testPower.Size = new System.Drawing.Size(500, 45);
            this.testPower.TabIndex = 1;
            this.testPower.Text = "testItem2";
            this.testPower.Title = "TEST POWER / SENSOR";
            this.testPower.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testPower.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testPower.TitleForeColor = System.Drawing.Color.White;
            this.testPower.TitleSize = 300;
            this.testPower.ButtonClick += new System.EventHandler(this.testPower_ButtonClick);
            // 
            // testGSM
            // 
            this.testGSM.BackColor = System.Drawing.Color.Transparent;
            this.testGSM.ButtonFlag = HBQ_Console_Interface.ButtonStatus.Start;
            this.testGSM.Cycle = 1;
            this.testGSM.CycleEnable = false;
            this.testGSM.CycleVisible = false;
            this.testGSM.Dock = System.Windows.Forms.DockStyle.Top;
            this.testGSM.ItemShow = HBQ_Console_Interface.TestItemShow.Numberic;
            this.testGSM.Location = new System.Drawing.Point(0, 0);
            this.testGSM.Message = "Message";
            this.testGSM.MessageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.testGSM.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testGSM.MessageForeColor = System.Drawing.SystemColors.ControlText;
            this.testGSM.MessageSize = 50;
            this.testGSM.MessageVisible = false;
            this.testGSM.Name = "testGSM";
            this.testGSM.Size = new System.Drawing.Size(500, 45);
            this.testGSM.TabIndex = 0;
            this.testGSM.Text = "testItem1";
            this.testGSM.Title = "TEST GSM";
            this.testGSM.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.testGSM.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testGSM.TitleForeColor = System.Drawing.Color.White;
            this.testGSM.TitleSize = 300;
            this.testGSM.ButtonClick += new System.EventHandler(this.testGSM_ButtonClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.btnExportTestConsole);
            this.panel3.Controls.Add(this.btnClearTestConsole);
            this.panel3.Controls.Add(this.txtTestConsole);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(500, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 723);
            this.panel3.TabIndex = 2;
            // 
            // btnExportTestConsole
            // 
            this.btnExportTestConsole.BorderColor = System.Drawing.Color.Silver;
            this.btnExportTestConsole.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.btnExportTestConsole.FlatAppearance.BorderSize = 0;
            this.btnExportTestConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTestConsole.Location = new System.Drawing.Point(105, 6);
            this.btnExportTestConsole.Name = "btnExportTestConsole";
            this.btnExportTestConsole.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(97)))), ((int)(((byte)(123)))));
            this.btnExportTestConsole.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExportTestConsole.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(230)))));
            this.btnExportTestConsole.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExportTestConsole.Size = new System.Drawing.Size(75, 23);
            this.btnExportTestConsole.TabIndex = 2;
            this.btnExportTestConsole.Text = "Export";
            this.btnExportTestConsole.TextColor = System.Drawing.Color.White;
            this.btnExportTestConsole.UseVisualStyleBackColor = true;
            this.btnExportTestConsole.Click += new System.EventHandler(this.btnExportTestConsole_Click);
            // 
            // btnClearTestConsole
            // 
            this.btnClearTestConsole.BorderColor = System.Drawing.Color.Silver;
            this.btnClearTestConsole.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.btnClearTestConsole.FlatAppearance.BorderSize = 0;
            this.btnClearTestConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTestConsole.Location = new System.Drawing.Point(7, 6);
            this.btnClearTestConsole.Name = "btnClearTestConsole";
            this.btnClearTestConsole.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(97)))), ((int)(((byte)(123)))));
            this.btnClearTestConsole.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClearTestConsole.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(230)))));
            this.btnClearTestConsole.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClearTestConsole.Size = new System.Drawing.Size(75, 23);
            this.btnClearTestConsole.TabIndex = 1;
            this.btnClearTestConsole.Text = "Clear";
            this.btnClearTestConsole.TextColor = System.Drawing.Color.White;
            this.btnClearTestConsole.UseVisualStyleBackColor = true;
            this.btnClearTestConsole.Click += new System.EventHandler(this.btnClearTestConsole_Click);
            // 
            // txtTestConsole
            // 
            this.txtTestConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTestConsole.Location = new System.Drawing.Point(7, 35);
            this.txtTestConsole.Name = "txtTestConsole";
            this.txtTestConsole.Size = new System.Drawing.Size(485, 676);
            this.txtTestConsole.TabIndex = 0;
            this.txtTestConsole.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsole";
            this.Text = "Console";
            this.EnabledChanged += new System.EventHandler(this.FormConsole_EnabledChanged);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private TestItem testPower;
        private TestItem testGSM;
        private System.Windows.Forms.RichTextBox txtTestConsole;
        private TestItem testReadFlash;
        private TestItem testEraseFlash;
        private TestItem testPerformance;
        private TestItem testFlowSensor;
        private TestItem testVSensor;
        private TestItem testPulse;
        private TestItem testSDCard;
        private TestItem testGPRS;
        private System.Windows.Forms.Timer timer1;
        private CircleButton btnClearTestConsole;
        private CircleButton btnExportTestConsole;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}