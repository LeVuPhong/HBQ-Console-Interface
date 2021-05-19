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
    public class CirclePannel : Panel
    {
        private int radius = 15;
        private GraphicsPath shape;
        private GraphicsPath innerRect;
        private Color backround;
        private Color _borderColor = Color.Gray;
        private int _borderSize = 0;
        public CirclePannel()
        {
            this.backround = Color.Transparent; ;
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.shape = new CustomRectangle((float)base.Width, (float)base.Height, (float)this.radius, 0f, 0f).Path;
            this.innerRect = new CustomRectangle(base.Width - 0.5f, base.Height - 0.5f, (float)this.radius, 0.5f, 0.5f).Path;
            e.Graphics.SmoothingMode = ((SmoothingMode)SmoothingMode.AntiAlias);
            //Bitmap bitmap = new Bitmap(base.Width, base.Height);
            //Graphics graphics = Graphics.FromImage((Image)bitmap);
            Pen pp = new Pen(_borderColor, _borderSize);
            //e.Graphics.DrawPath(pp, this.shape);
            using (SolidBrush brush = new SolidBrush(this.backround))
            {
                e.Graphics.FillPath((Brush)brush, this.innerRect);
            }
            //Trans.MakeTransparent(this, e.Graphics);
            
        }
        public int PannelRadius
        {
            get =>
                this.radius;
            set { this.radius = value; Invalidate(); }
        }
        public Color Backround
        {
            get =>
                this.backround;
            set
            {
                this.backround = value;
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
        public int BorderSize
        {
            get =>
                this._borderSize;
            set { this._borderSize = value; Invalidate(); }
        }
    }
}
