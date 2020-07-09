using System;
using Spreadex.Factories;

namespace Spreadex.Manager
{
    public static class DrawManager
    {
        public static DrawManager DrawShape(this DrawManager manager, ShapeFactory factory)
        {
            Console.WriteLine(factory.GetShape().DrawShape());

            return manager;
        }
    }
}
