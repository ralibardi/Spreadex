using Spreadex.Shapes;
using Spreadex.Shapes.Enums;
using Spreadex.Shapes.Interfaces;

namespace Spreadex.Factories
{
    public class SquareFactory : ShapeFactory
    {
        private readonly int[] _info;

        public SquareFactory(int[] info)
        {
            _info = info;
        }

        public override IBasicShape GetShape()
        {
            return new Square(_info[(int)WidgetParams.StartX], _info[(int)WidgetParams.StartY])
            {
                Size = _info[(int)WidgetParams.Size]
            };
        }
    }
}