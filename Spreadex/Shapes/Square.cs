using System.Text;

namespace Spreadex.Shapes
{
    public class Square : BasicShape
    {
        private int _size;

        public int Size
        {
            private get => _size;
            set => _size = value > 0 ? value : 0;
        }

        public Square(int startX, int startY) : base(startX, startY)
        {
            ShapeName = this.GetType().Name;
        }

        public override string DrawShape()
        {
            var drawing = new StringBuilder();

            drawing.Append(string.Format(Resources.WidgetHeader, ShapeName, StartX, StartY));
            drawing.Append(" ");
            drawing.Append(string.Format(Resources.WidgetSize, Size));

            return drawing.ToString();
        }
    }
}