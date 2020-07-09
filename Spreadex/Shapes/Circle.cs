using System.Text;

namespace Spreadex.Shapes
{
    public class Circle : BasicShape
    {
        private int _diameter;

        public int Diameter
        {
            private get => _diameter;
            set => _diameter = value > 0 ? value : 0;
        }

        public Circle(int startX, int startY) : base(startX, startY)
        {
        }

        public override string DrawShape()
        {
            var drawing = new StringBuilder();

            drawing.Append(string.Format(Resources.WidgetHeader, nameof(Circle), StartX, StartY));
            drawing.Append(" ");
            drawing.Append(string.Format(Resources.WidgetSize, Diameter));

            return drawing.ToString();
        }
    }
}