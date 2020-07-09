using System;

namespace Spreadex.Shapes
{
    // A Square is a rectangle with 2 equal sides
    public class Square : Rectangle
    {
        private int _size;

        public int Size
        {
            private get => _size;
            set => _size = value > 1 ? value : 1; // There's no point in creating a shape with size less than 1 (since we are using ints)
        }

        public Square(int startX, int startY) : base(startX, startY)
        {
            ShapeName = this.GetType().Name;
        }

        public override void DrawShape()
        {
            Console.Write(Resources.WidgetHeader, ShapeName, StartX, StartY);
            Console.Write(Resources.WidgetDrawingSeparator);
            Console.Write(Resources.WidgetSize, Size);
        }
    }
}