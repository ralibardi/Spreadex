using System;
using System.Text;

namespace Spreadex.Shapes
{
    public class TextBox : Rectangle
    {
        public string Text { get; set; }

        public TextBox(int startX, int startY) : base(startX, startY)
        {
        }

        public override string DrawShape()
        {
            var drawing = new StringBuilder();

            drawing.Append(base.DrawShape());
            drawing.Append(" ");
            drawing.Append(string.Format(Resources.WidgetText, Text));

            return drawing.ToString();
        }
    }
}