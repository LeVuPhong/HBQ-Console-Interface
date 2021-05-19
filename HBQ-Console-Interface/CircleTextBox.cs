using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HBQ_Console_Interface
{
    public class CircleTextBox : Control
    {
        private int radius = 15;
        public TextBox textbox = new TextBox();
        private GraphicsPath shape;
        private GraphicsPath innerRect;
        private Color backround;
        private Color _borderColor = Color.Gray;
        private int _borderSize = 1;
        private TextBoxValueType _valueType = TextBoxValueType.String;
        public CircleTextBox()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            this.textbox.Parent = this;
            base.Controls.Add(this.textbox);
            this.textbox.BorderStyle = BorderStyle.None;
            this.textbox.Font = this.Font;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.backround = Color.White;
            textbox.BackColor = this.backround;

            this.Text = null;
            //this.Font = new Font("Century Gothic", 12f);
            base.Size = new Size(135, 30);
            this.DoubleBuffered = true;
            textbox.KeyDown += new KeyEventHandler(textbox_KeyDown);
            textbox.TextChanged += new EventHandler(textbox_TextChanged);
            textbox.MouseDoubleClick += new MouseEventHandler(textbox_MouseDoubleClick);
            textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textbox_KeyPress);
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        private void textbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textbox.SelectAll();
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if(_valueType == TextBoxValueType.Number)
            {
                for (int i = 0; i < textbox.Text.Length; i++)
                {
                    if(textbox.Text[i] < '0' || textbox.Text[i] > '9')
                    {
                        textbox.Text = textbox.Text.Remove(i, 1);
                        textbox.SelectionStart = textbox.Text.Length;
                    }
                }
            }
            
            this.Text = textbox.Text;
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                textbox.SelectionStart = 0;
                textbox.SelectionLength = this.Text.Length;
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            textbox.Font = this.Font;
            base.Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            textbox.ForeColor = this.ForeColor;
            base.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.shape = new CustomRectangle((float)base.Width, (float)base.Height, (float)this.radius, 0f, 0f).Path;
            this.innerRect = new CustomRectangle(base.Width - 0.5f, base.Height - 0.5f, (float)this.radius, 0.5f, 0.5f).Path;
            if (textbox.Height >= (base.Height - 4))
            {
                base.Height = textbox.Height + 4;
            }
            textbox.Location = new Point(this.radius + 2, (base.Height / 2) - (textbox.Font.Height / 2));
            textbox.Width = base.Width - ((int)(this.radius * 1.5))-5;
            e.Graphics.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            Bitmap bitmap = new Bitmap(base.Width, base.Height);
            Graphics graphics = Graphics.FromImage((Image)bitmap);
            Pen pp = new Pen(_borderColor, _borderSize);
            e.Graphics.DrawPath(pp, this.shape);

            using (SolidBrush brush = new SolidBrush(this.backround))
            {
                e.Graphics.FillPath((Brush)brush, this.innerRect);
            }
            Trans.MakeTransparent(this, e.Graphics);
            base.OnPaint(e);
        }


        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            textbox.Text = this.Text;
        }
        public void SelectAll()
        {
            textbox.SelectAll();
        }
        public char PasswordChar
        {
            get =>
                textbox.PasswordChar;
            set
            {
                textbox.PasswordChar = value;
                base.Invalidate();
            }

        }
        public bool UseSystemPasswordChar
        {
            get =>
                textbox.UseSystemPasswordChar;
            set
            {
                textbox.UseSystemPasswordChar = value;
                base.Invalidate();
            }

        }
        public Color Backround
        {
            get =>
                this.backround;
            set
            {
                this.backround = value;
                if (this.backround != Color.Transparent)
                {
                    textbox.BackColor = this.backround;
                }
                base.Invalidate();
            }
        }
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = Color.Transparent;
        }
        public Color BorderColor
        {
            get =>
                this._borderColor;
            set { this._borderColor = value; Invalidate(); }
        }
        public int textboxRadius
        {
            get =>
                this.radius;
            set { this.radius = value; Invalidate(); }
        }
        public int BorderSize
        {
            get =>
                this._borderSize;
            set { this._borderSize = value; Invalidate(); }
        }

        public TextBoxValueType ValueType
        {
            get => _valueType;
            set => _valueType = value;
        }
    }
}
