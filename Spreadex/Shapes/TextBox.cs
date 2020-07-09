using System;
using Spreadex.Shapes.Interfaces;

namespace Spreadex.Shapes
{
    // A textBox is a rectangle with text on top
    public class TextBox : IBasicShape
    {
        private readonly Rectangle _canvas;
        public string Text { get; set; }

        public TextBox(Rectangle canvas)
        {
            _canvas = canvas;
            _canvas.ShapeName = this.GetType().Name;
        }

        public void DrawShape()
        {
            _canvas.DrawShape();

            Console.Write(Resources.WidgetDrawingSeparator);
            Console.Write(Resources.WidgetText, Text);
        }
    }
}