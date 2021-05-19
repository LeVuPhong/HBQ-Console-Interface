namespace HBQ_Console_Interface
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new HBQ_Console_Interface.CirclePannel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numCycle = new System.Windows.Forms.NumericUpDown();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.circlePannel1 = new HBQ_Console_Interface.CirclePannel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).BeginInit();
            this.circlePannel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Backround = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.panelTitle.BorderColor = System.Drawing.Color.Gray;
            this.panelTitle.BorderSize = 0;
            this.panelTitle.Controls.Add(this.panel3);
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Controls.Add(this.panel2);
            this.panelTitle.Controls.Add(this.circlePannel1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.PannelRadius = 10;
            this.panelTitle.Size = new System.Drawing.Size(600, 45);
            this.panelTitle.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.numCycle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 45);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "x 1s";
            // 
            // numCycle
            // 
            this.numCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCycle.Location = new System.Drawing.Point(6, 12);
            this.numCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCycle.Name = "numCycle";
            this.numCycle.Size = new System.Drawing.Size(124, 22);
            this.numCycle.TabIndex = 3;
            this.numCycle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Location = new System.Drawing.Point(25, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(200, 45);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Test Item";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 45);
            this.panel2.TabIndex = 1;
            // 
            // circlePannel1
            // 
            this.circlePannel1.BackColor = System.Drawing.Color.Transparent;
            this.circlePannel1.Backround = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.circlePannel1.BorderColor = System.Drawing.Color.Gray;
            this.circlePannel1.BorderSize = 0;
            this.circlePannel1.Controls.Add(this.lbMessage);
            this.circlePannel1.Controls.Add(this.btnStartStop);
            this.circlePannel1.Controls.Add(this.panel1);
            this.circlePannel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.circlePannel1.Location = new System.Drawing.Point(400, 0);
            this.circlePannel1.Name = "circlePannel1";
            this.circlePannel1.PannelRadius = 10;
            this.circlePannel1.Size = new System.Drawing.Size(200, 45);
            this.circlePannel1.TabIndex = 0;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(45, 14);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(65, 17);
            this.lbMessage.TabIndex = 5;
            this.lbMessage.Text = "Message";
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartStop.FlatAppearance.BorderSize = 0;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Image = global::HBQ_Console_Interface.Properties.Resources.start1;
            this.btnStartStop.Location = new System.Drawing.Point(10, 10);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(25, 25);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 43);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Visible = false;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelTitle);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(600, 45);
            this.panelTitle.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).EndInit();
            this.circlePannel1.ResumeLayout(false);
            this.circlePannel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CirclePannel panelTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private CirclePannel circlePannel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numCycle;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
