using Spreadex.Shapes;
using Spreadex.Shapes.Enums;
using Spreadex.Shapes.Interfaces;

namespace Spreadex.Factories
{
    public class ElipseFactory : ShapeFactory
    {
        public ElipseFactory(int[] info) : base(info)
        {
        }

        public override IBasicShape GetShape()
        {
            return new Elipse(Info[(int)WidgetParams.StartX], Info[(int)WidgetParams.StartY])
            {
                DiameterX = Info[(int)WidgetParams.Width],
                DiameterY = Info[(int)WidgetParams.Height]
            };
        }

        
    }
}