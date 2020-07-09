using System;
using System.Text;

namespace Spreadex.Shapes
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;


        public int Width
        {
            private get => _width;
            set => _width = value > 0 ? value : 0;
        }

        public int Height
        {
            private get => _height;
            set => _height = value > 0 ? value : 0;
        }

        public Rectangle(int startX, int startY) : base(startX, startY)
        {
        }

        public override string DrawShape()
        {
            var drawing = new StringBuilder();

            drawing.Append(string.Format(Resources.WidgetHeader, nameof(Rectangle), StartX, StartY));
            drawing.Append(" ");
            drawing.Append(string.Format(Resources.WidgetWidth, Width));
            drawing.Append(" ");
            drawing.Append(string.Format(Resources.WidgetHeight, Height));

            return drawing.ToString();
        }
    }
}