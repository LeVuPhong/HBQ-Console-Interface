using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HBQ_Console_Interface
{
    public class TestItem : Control
    {
        private ButtonStatus buttonFlag = ButtonStatus.Start;
        private TestItemShow itemShow = TestItemShow.Numberic;
        public TestItem()
        {
            InitializeComponent();
            
        }

        private void setButtonFlag(ButtonStatus flag)
        {
            if(flag == ButtonStatus.Start)
            {
                btnStartStop.Image = Properties.Resources.start1;
            }
            else
            {
                btnStartStop.Image = Properties.Resources.stop1;
            }
        }

        #region public properties
        public string Title
        {
            get => lbTitle.Text;
            set => lbTitle.Text = value;
        }
        public int TitleSize
        {
            get => lbTitle.Width;
            set => lbTitle.Width = value;
        }
        public Font TitleFont
        {
            get => lbTitle.Font;
            set => lbTitle.Font = value;
        }
        public Color TitleForeColor
        {
            get => lbTitle.ForeColor;
            set => lbTitle.ForeColor = value;
        }
        public Color TitleBackColor
        {
            get => panelTitle.Backround;
            set => panelTitle.Backround = value;
        }

        public string Message
        {
            get => lbMessage.Text;
            set => lbMessage.Text = value;
        }
        public int MessageSize
        {
            get => panelMessage.Width;
            set => panelMessage.Width = value;
        }
        public Font MessageFont
        {
            get => lbMessage.Font;
            set => lbMessage.Font = value;
        }
        public Color MessageForeColor
        {
            get => lbMessage.ForeColor;
            set => lbMessage.ForeColor = value;
        }
        public Color MessageBackColor
        {
            get => panelMessage.Backround;
            set => panelMessage.Backround = value;
        }
        public bool MessageVisible
        {
            get => lbMessage.Visible;
            set => lbMessage.Visible = value;
        }
        public int Cycle
        {
            get => (int)numCycle.Value;
            set => numCycle.Value = value;
        }
        public bool CycleVisible
        {
            get => panelCycle.Visible;
            set => panelCycle.Visible = value;
        }
        public bool CycleEnable
        {
            get => numCycle.Enabled;
            set => numCycle.Enabled = value;
        }
        public ButtonStatus ButtonFlag
        {
            get => buttonFlag;
            set
            {
                buttonFlag = value;
                setButtonFlag(buttonFlag);
            }
        }
        public TestItemShow ItemShow
        {
            get => itemShow;
            set
            {
                itemShow = value;
                if(itemShow == TestItemShow.HideAll)
                {
                    label1.Visible = false;
                    numCycle.Visible = false;
                    comboBox.Visible = false;
                }
                else if(itemShow == TestItemShow.Numberic)
                {
                    label1.Visible = true;
                    numCycle.Visible = true;
                    comboBox.Visible = false;
                }
                else if (itemShow == TestItemShow.ComboBox)
                {
                    label1.Visible = false;
                    numCycle.Visible = false;
                    comboBox.Visible = true;
                }
            }
        }

        public event EventHandler ButtonClick;
        #endregion

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new HBQ_Console_Interface.CirclePannel();
            this.panelCycle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numCycle = new System.Windows.Forms.NumericUpDown();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMessage = new HBQ_Console_Interface.CirclePannel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.panelCycle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).BeginInit();
            this.panelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Backround = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.panelTitle.BorderColor = System.Drawing.Color.Gray;
            this.panelTitle.BorderSize = 0;
            this.panelTitle.Controls.Add(this.panelCycle);
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Controls.Add(this.panel2);
            this.panelTitle.Controls.Add(this.panelMessage);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.PannelRadius = 10;
            this.panelTitle.Size = new System.Drawing.Size(600, 45);
            this.panelTitle.TabIndex = 1;
            // 
            // panelCycle
            // 
            this.panelCycle.BackColor = System.Drawing.Color.Transparent;
            this.panelCycle.Controls.Add(this.label1);
            this.panelCycle.Controls.Add(this.numCycle);
            this.panelCycle.Controls.Add(this.comboBox);
            this.panelCycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCycle.Location = new System.Drawing.Point(215, 0);
            this.panelCycle.Name = "panelCycle";
            this.panelCycle.Size = new System.Drawing.Size(185, 45);
            this.panelCycle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 14);
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
            this.numCycle.Size = new System.Drawing.Size(134, 22);
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
            this.lbTitle.Location = new System.Drawing.Point(15, 0);
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
            this.panel2.Size = new System.Drawing.Size(15, 45);
            this.panel2.TabIndex = 1;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.Transparent;
            this.panelMessage.Backround = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.panelMessage.BorderColor = System.Drawing.Color.Gray;
            this.panelMessage.BorderSize = 0;
            this.panelMessage.Controls.Add(this.lbMessage);
            this.panelMessage.Controls.Add(this.btnStartStop);
            this.panelMessage.Controls.Add(this.panel1);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMessage.Location = new System.Drawing.Point(400, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.PannelRadius = 10;
            this.panelMessage.Size = new System.Drawing.Size(200, 45);
            this.panelMessage.TabIndex = 0;
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
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
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
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(5, 10);
            this.comboBox.Name = "comboBox1";
            this.comboBox.Size = new System.Drawing.Size(165, 24);
            this.comboBox.TabIndex = 5;
            this.comboBox.Visible = false;
            // 
            // TestItem
            // 
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Controls.Add(this.panelTitle);
            this.Name = "TestItem";
            this.Size = new System.Drawing.Size(600, 45);
            this.panelTitle.ResumeLayout(false);
            this.panelCycle.ResumeLayout(false);
            this.panelCycle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).EndInit();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CirclePannel panelTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private CirclePannel panelMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numCycle;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel panelCycle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox;

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if(ButtonClick != null)
            {
                ButtonClick?.Invoke(sender, e);
            }
        }
    }
    public enum ButtonStatus
    {
        Stop = 0,
        Start = 1,
    }
}
