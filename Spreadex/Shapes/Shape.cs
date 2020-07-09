namespace Spreadex.Shapes
{
    public abstract class Shape : IShape
    {
        internal int StartX;
        internal int StartY;

        protected Shape(int startX, int startY)
        {
            StartX = startX >= 0 ? startX : 0;
            StartY = startY >= 0 ? startY : 0;
        }

        public abstract string DrawShape();
    }
}