using System.Text;
using Spreadex.Shapes.Interfaces;

namespace Spreadex.Shapes
{
    public class TextBox : IBasicShape
    {
        private readonly Rectangle _canvas;
        public string Text { get; set; }

        public TextBox(Rectangle canvas)
        {
            _canvas = canvas;
            _canvas.ShapeName = this.GetType().Name;
        }

        public string DrawShape()
        {
            var drawing = new StringBuilder();

            drawing.Append(_canvas.DrawShape());
            drawing.Append(" ");
            drawing.Append(string.Format(Resources.WidgetText, Text));

            return drawing.ToString();
        }
    }
}