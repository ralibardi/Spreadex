using Spreadex.Shapes;
using Spreadex.Shapes.Interfaces;

namespace Spreadex.Factories
{
    public class TextBoxFactory : ShapeFactory
    {
        private readonly string _text;

        public TextBoxFactory(int[] info, string text) : base(info)
        {
            _text = text;
        }

        public override IBasicShape GetShape()
        {
            var factory = new RectangleFactory(Info);
            var textBox = new TextBox(factory.GetShape() as Rectangle)
            {
                Text = _text
            };

            return textBox;
        }
    }
}