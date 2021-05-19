using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HBQ_Console_Interface
{
    public class ParameterItem : Panel
    {
        public delegate void SpanColumsEventHandler(Control control, int span);
        public event SpanColumsEventHandler SpanColumChange;
        private int span;
        private ParameterItemType itemType = ParameterItemType.TextBox;
        public ParameterItem()
        {
            InitializeComponent();
            //this.BackColor = Color.Transparent;
            //panel1.SendToBack();
            span = 1;

        }
        public void setText(string value)
        {
            this.Invoke(new Action(() =>
            {
                this.textBox.Text = value;
            }));
        }
        public void RemoveSpanEvent()
        {
            if(SpanColumChange != null)
            {
                foreach (SpanColumsEventHandler eh in SpanColumChange.GetInvocationList())
                {
                    SpanColumChange -= eh;
                }
            }
        }
        public int Span
        {
            get => span;
            set
            {
                if(value >= 1 && value <= 4)
                {
                    span = value;
                    if(SpanColumChange != null)
                    {
                        SpanColumChange?.Invoke(this, span);
                    }
                }
            }
        }
        public bool ReadOnly
        {
            get => textBox.ReadOnly;// readOnly;
            set
            {
                //readOnly = value;
                textBox.ReadOnly = value;
            }
        }
        public int TitleWidth
        {
            get => lbTitle.Width;
            set
            {
                lbTitle.Width = value;
                textBox.Location = new Point(lbTitle.Location.X + lbTitle.Width, 1);
                textBox.Width = this.Width - (textBox.Location.X + 5);
            }
        }
        public string Title
        {
            get => lbTitle.Text;
            set => lbTitle.Text = value;
        }
        public string TextValue
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }
        
        public ParameterItemType ItemType
        {
            get => itemType;
            set
            {
                itemType = value;
                if(itemType == ParameterItemType.TextBox)
                {
                    textBox.Visible = true;
                    comboBox.Visible = false;
                }
                else if (itemType == ParameterItemType.ComboBox)
                {
                    textBox.Visible = false;
                    comboBox.Visible = true;
                }
            }
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 26);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 26);
            this.panel2.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Location = new System.Drawing.Point(5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(100, 26);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Item";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(105, 1);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(190, 24);
            this.textBox.TabIndex = 5;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(105, 0);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(190, 26);
            this.comboBox.TabIndex = 6;
            this.comboBox.Visible = false;
            // 
            // UserControl1
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(0, 26);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(300, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        public System.Windows.Forms.TextBox textBox;
        public System.Windows.Forms.ComboBox comboBox;
    }
}
