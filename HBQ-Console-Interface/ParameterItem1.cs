using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HBQ_Console_Interface
{
    public class ParameterItem1 : Panel
    {
        public delegate void SpanColumsEventHandler(Control control, int span);
        public event SpanColumsEventHandler SpanColumChange;
        private int span;
        private ParameterItemType itemType = ParameterItemType.TextBox;
        public ParameterItem1()
        {
            InitializeComponent();
            //this.BackColor = Color.Transparent;
            panel1.SendToBack();
            span = 1;

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
            get => textBox.textbox.ReadOnly;// readOnly;
            set
            {
                //readOnly = value;
                textBox.textbox.ReadOnly = value;
            }
        }
        public int TitleWidth
        {
            get => lbTitle.Width;
            set => lbTitle.Width = value;
        }
        public string Title
        {
            get => lbTitle.Text;
            set => lbTitle.Text = value;
        }
        public string TextValue
        {
            get => textBox.textbox.Text;
            set => textBox.textbox.Text = value;
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
                    //this.Controls.Add(textBox);
                    //this.Controls.Remove(comboBox);
                }
                else if (itemType == ParameterItemType.ComboBox)
                {
                    textBox.Visible = false;
                    comboBox.Visible = true;
                    //this.Controls.Add(comboBox);
                    //this.Controls.Remove(textBox);
                }
            }
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox = new CircleTextBox();
            this.comboBox = new ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 30);
            this.panel2.TabIndex = 1;
            // 
            // textBox
            // 
            //this.textBox.BackColor = System.Drawing.Color.Transparent;
            this.textBox.Backround = System.Drawing.Color.White;
            this.textBox.BorderColor = System.Drawing.Color.Black;
            this.textBox.BorderSize = 1;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(105, 0);
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.Size = new System.Drawing.Size(190, 30);
            this.textBox.TabIndex = 5;
            this.textBox.textboxRadius = 5;
            this.textBox.UseSystemPasswordChar = false;
            this.textBox.ValueType = HBQ_Console_Interface.TextBoxValueType.String;
            //this.textBox.Visible = false;
            // 
            // circleComboBox
            // 
            
            //this.comboBox.BackColor = System.Drawing.Color.Transparent;
            //this.comboBox.Backround = System.Drawing.Color.White;
            //this.comboBox.BorderColor = System.Drawing.Color.Black;
            //this.comboBox.BorderSize = 1;
            //this.comboBox.ComboBoxRadius = 5;
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox.ForeColor = System.Drawing.Color.Black;
            this.comboBox.Location = new System.Drawing.Point(105, 0);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(190, 30);
            this.comboBox.TabIndex = 6;
            this.comboBox.Visible = false;
            
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Location = new System.Drawing.Point(5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(100, 30);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Item";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ParameterItem
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ParameterItem";
            this.Size = new System.Drawing.Size(300, 30);
            this.ResumeLayout(false);

            this.panel1.SendToBack();
            this.panel2.SendToBack();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbTitle;
        public CircleTextBox textBox;
        public ComboBox comboBox;
    }
}
