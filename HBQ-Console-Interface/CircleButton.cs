using System;
using System.Windows.Forms;
using System.Drawing;

namespace HBQ_Console_Interface
{
    public class CircleButton : Button
    {
        private Color _borderColor = Color.Silver;
        private Color _onHoverBorderColor = Color.Transparent;
        private Color _buttonColor = Color.Red;
        private Color _onHoverButtonColor = Color.Yellow;
        private Color _textColor = Color.White;
        private Color _onHoverTextColor = Color.Gray;
        private Color _onClickColor = Color.DarkOrange;

        private bool _isHovering;
        private bool _isClick;
        private int _borderThickness = 0;
        private int _borderThicknessByTwo = 0;
        public CircleButton()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHovering = false;
                Invalidate();
            };
            MouseDown += (sender, e) =>
            {
                _isClick = true;
                Invalidate();
            };
            MouseUp += (sender, e) =>
            {
                _isClick = false;
                Invalidate();
            };
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(_isHovering ? _onHoverBorderColor : _borderColor);

            //Border
            //g.FillEllipse(brush, 0, 0, Height, Height);
            //g.FillEllipse(brush, Width - Height, 0, Height, Height);
            //g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverButtonColor : _buttonColor);
            if(_isClick)
            {
                brush = new SolidBrush(_onClickColor);

            }
            //Inner part. Button itself
            /*
            g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness,
                Height - _borderThickness);
            g.FillEllipse(brush, (Width - Height) + _borderThicknessByTwo, _borderThicknessByTwo,
                Height - _borderThickness, Height - _borderThickness);
            g.FillRectangle(brush, Height /2 + _borderThicknessByTwo, _borderThicknessByTwo,
                Width - Height - _borderThickness, Height - _borderThickness);
            */
            g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height / 4, Height / 4);//top - left
            g.FillEllipse(brush, _borderThicknessByTwo, Height - (Height / 4), Height / 4, Height / 4);//bottom - left
            g.FillEllipse(brush, (Width - Height/4) + _borderThicknessByTwo, _borderThicknessByTwo, Height / 4, Height / 4);//top - right
            g.FillEllipse(brush, (Width - Height/4) + _borderThicknessByTwo, Height - (Height / 4), Height / 4, Height / 4);//bottom - right
            g.FillRectangle(brush, Height / 8 + _borderThicknessByTwo, _borderThicknessByTwo,Width - (Height/4) - _borderThickness, Height - _borderThickness);
            g.FillRectangle(brush, _borderThicknessByTwo, (Height / 8) - _borderThicknessByTwo, Width - _borderThickness, Height - (Height / 4) - _borderThickness);
            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);

            //Button Text
            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
            
        }
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public Color OnHoverBorderColor
        {
            get => _onHoverBorderColor;
            set
            {
                _onHoverBorderColor = value;
                Invalidate();
            }
        }

        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }

        public Color OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public Color OnHoverTextColor
        {
            get => _onHoverTextColor;
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }
        public Color OnClickColor
        {
            get => _onClickColor;
            set
            {
                _onClickColor = value;
                Invalidate();
            }
        }
    }
}
