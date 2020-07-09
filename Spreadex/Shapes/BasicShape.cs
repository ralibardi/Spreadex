using Spreadex.Shapes.Interfaces;

namespace Spreadex.Shapes
{
    public abstract class BasicShape : IBasicShape
    {
        internal int StartX;
        internal int StartY;
        internal string ShapeName;

        protected BasicShape(int startX, int startY)
        {
            StartX = startX > 0 ? startX : 0;
            StartY = startY > 0 ? startY : 0;
        }

        public abstract void DrawShape();
    }
}