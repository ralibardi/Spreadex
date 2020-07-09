using Spreadex.Shapes.Interfaces;

namespace Spreadex.Factories
{
    public abstract class ShapeFactory
    {
        internal readonly int[] Info;

        protected ShapeFactory(int[] info)
        {
            Info = info;
        }

        // It's important to have a GetShape so we can use the factory in another part of the code
        public abstract IBasicShape GetShape();
    }
}