using System;

namespace Spreadex.Shapes
{
    public class Elipse : BasicShape
    {
        private int _diameterX;
        private int _diameterY;

        public int DiameterX
        {
            private get => _diameterX;
            set => _diameterX = value > 1 ? value : 1;// There's no point in creating a shape with width less than 1 (since we are using ints)
        }

        public int DiameterY
        {
            private get => _diameterY;
            set => _diameterY = value > 1 ? value :1; // There's no point in creating a shape with height less than 1 (since we are using ints)
        }

        public Elipse(int startX, int startY) : base(startX, startY)
        {
            ShapeName = this.GetType().Name;
        }

        public override void DrawShape()
        {
            Console.Write(Resources.WidgetHeader, ShapeName, StartX, StartY);
            Console.Write(Resources.WidgetDrawingSeparator);
            Console.Write(Resources.WidgetWidth, DiameterX);
            Console.Write(Resources.WidgetDrawingSeparator);
            Console.Write(Resources.WidgetHeight, DiameterY);
        }
    }
}