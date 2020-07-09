using System;

namespace Spreadex.Shapes
{
    public class Rectangle : BasicShape
    {
        private int _width;
        private int _height;

        public int Width
        {
            private get => _width;
            set => _width = value > 1 ? value : 1; // There's no point in creating a shape with width less than 1 (since we are using ints)
        }

        public int Height
        {
            private get => _height;
            set => _height = value > 1 ? value : 1; // There's no point in creating a shape with height less than 1 (since we are using ints)
        }

        public Rectangle(int startX, int startY) : base(startX, startY)
        {
            ShapeName = this.GetType().Name;
        }

        public override void DrawShape()
        {
            Console.Write(Resources.WidgetHeader, ShapeName, StartX, StartY);
            Console.Write(Resources.WidgetDrawingSeparator);
            Console.Write(Resources.WidgetWidth, Width);
            Console.Write(Resources.WidgetDrawingSeparator);
            Console.Write(Resources.WidgetHeight, Height);
        }
    }
}