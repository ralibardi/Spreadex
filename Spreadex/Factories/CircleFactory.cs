using Spreadex.Shapes;
using Spreadex.Shapes.Enums;
using Spreadex.Shapes.Interfaces;

namespace Spreadex.Factories
{
    public class CircleFactory : ShapeFactory
    {
        public CircleFactory(int[] info) : base(info)
        {
        }

        public override IBasicShape GetShape()
        {
            return new Circle(Info[(int)WidgetParams.StartX], Info[(int)WidgetParams.StartY])
            {
                Diameter = Info[(int)WidgetParams.Size]
            };
        }
    }
}