using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace HBQ_Console_Interface
{
    public class CircleComboBox : Control
    {
        private int radius = 15;
        public ComboBox combobox = new ComboBox();
        private GraphicsPath shape;
        private GraphicsPath innerRect;
        private Color backround;
        private Color _borderColor = Color.Gray;
        private int _borderSize = 1;
        public CircleComboBox()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            this.combobox.Parent = this;
            base.Controls.Add(this.combobox);
            //this.combobox.BorderStyle = BorderStyle.None;
            
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.backround = Color.White;//FromArgb(225, 225, 225); ;
            this.combobox.BackColor = this.backround;
            this.combobox.Font = this.Font;
            this.combobox.FlatStyle = FlatStyle.Flat;
            this.combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            //this.combobox.bo

            this.Text = null;
            //this.Font = new Font("Century Gothic", 12f);
            base.Size = new Size(135, 30);
            this.DoubleBuffered = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.shape = new CustomRectangle((float)base.Width, (float)base.Height, (float)this.radius, 0f, 0f).Path;
            this.innerRect = new CustomRectangle(base.Width - 0.5f, base.Height - 0.5f, (float)this.radius, 0.5f, 0.5f).Path;
            if (combobox.Height >= (base.Height - 4))
            {
                base.Height = combobox.Height + 4;
            }
            combobox.Location = new Point(this.radius, (base.Height / 4) - (combobox.Font.Height / 4));
            combobox.Width = base.Width - ((int)(this.radius * 1.5)) - 2;
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
        public void AddRangeItem(object[] items)
        {
            combobox.Items.AddRange(items);
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
                    combobox.BackColor = this.backround;
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
        public int ComboBoxRadius
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
    }
}
