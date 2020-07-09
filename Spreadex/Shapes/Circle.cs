using System;

namespace Spreadex.Shapes
{
    // A circle is a elipse where the 2 diamiters are equal
    public class Circle : Elipse
    {
        private int _diameter;

        public int Diameter
        {
            private get => _diameter;
            set => _diameter = value > 1 ? value : 1; // There's no point in creating a shape with size less than 1 (since we are using ints)
        }

        public Circle(int startX, int startY) : base(startX, startY)
        {
            ShapeName = this.GetType().Name;
        }

        public override void DrawShape()
        {
            Console.Write(Resources.WidgetHeader, ShapeName, StartX, StartY);
            Console.Write(Resources.WidgetDrawingSeparator);
            Console.Write(Resources.WidgetSize, Diameter);
        }
    }
}