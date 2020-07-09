using System.Text;

namespace Spreadex.Shapes
{
    public class Elipse : BasicShape
    {
        private int _diameterX;
        private int _diameterY;

        public int DiameterX
        {
            private get => _diameterX;
            set => _diameterX = value > 0 ? value : 0;
        }

        public int DiameterY
        {
            private get => _diameterY;
            set => _diameterY = value > 0 ? value : 0;
        }

        public Elipse(int startX, int startY) : base(startX, startY)
        {
        }

        public override string DrawShape()
        {
            var drawing = new StringBuilder();

            drawing.Append(string.Format(Resources.WidgetHeader, nameof(Elipse), StartX, StartY));
            drawing.Append(" ");
            drawing.Append(string.Format(Resources.WidgetWidth, DiameterX));
            drawing.Append(" ");
            drawing.Append(string.Format(Resources.WidgetHeight, DiameterY));

            return drawing.ToString();
        }
    }
}