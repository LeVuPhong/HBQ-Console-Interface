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
    internal class CustomRectangle
    {
        private Point location;
        private float radius;
        private GraphicsPath graphicsPath;
        private float x;
        private float y;
        private float height;
        private float width;
        public CustomRectangle() { }
        public CustomRectangle(float width, float height, float radius, float x = 0f, float y = 0f)
        {
            this.location = new Point(0, 0);
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.width = width;
            this.height = height;
            this.graphicsPath = new GraphicsPath();
            if(radius < 0f)
            {
                this.graphicsPath.AddRectangle(new RectangleF(x, y, width, height));

            }
            else
            {
                RectangleF ef1 = new RectangleF(x, y, 2f * radius, 2f * radius - 1);
                RectangleF ef2 = new RectangleF((width - (2f * radius)) - 1f, x, 2f * radius, 2f * radius);
                RectangleF ef3 = new RectangleF(x, (height - (2f * radius)) - 1f, 2f * radius, 2f * radius);
                RectangleF ef4 = new RectangleF((width - (2f * radius)) - 1f, (height - (2f * radius)), 2f * radius, 2f * radius -1);
                this.graphicsPath.AddArc(ef1, 180f, 90f);
                this.graphicsPath.AddArc(ef2, 270f, 90f);
                this.graphicsPath.AddArc(ef4, 0f, 90f);
                this.graphicsPath.AddArc(ef3, 90f, 90f);
                
                this.graphicsPath.CloseAllFigures();
            }

        }

        public GraphicsPath Path => this.graphicsPath;

        public RectangleF Rect => new RectangleF(this.x, this.y, this.width, this.height);

        public float Radius
        {
            get => this.radius;
            set => this.radius = value;
        }

    }
}
