using Spreadex.Shapes;
using Spreadex.Shapes.Enums;
using Spreadex.Shapes.Interfaces;

namespace Spreadex.Factories
{
    public class RectangleFactory : ShapeFactory
    {
        public RectangleFactory(int[] info) : base(info)
        {
        }

        public override IBasicShape GetShape()
        {
            return new Rectangle(Info[(int)WidgetParams.StartX], Info[(int)WidgetParams.StartY])
            {
                Width = Info[(int)WidgetParams.Width],
                Height = Info[(int)WidgetParams.Height]
            };
        }
    }
}