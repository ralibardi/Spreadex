using System;
using Spreadex.Factories;
using Spreadex.Shapes.Enums;

namespace Spreadex
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var info = new int[5];
            var factory = new WidgetFactory();

            // Rectangle Data
            info[(int) WidgetParams.StartX] = 10;
            info[(int)WidgetParams.StartY] = 10;
            info[(int)WidgetParams.Width] = 30;
            info[(int)WidgetParams.Height] = 40;

            var rectangle = factory.GetShape(WidgetsAvailable.Rectangle, info);
            Console.WriteLine(rectangle.DrawShape());

            // Square Data
            info[(int)WidgetParams.StartX] = 15;
            info[(int)WidgetParams.StartY] = 30;
            info[(int)WidgetParams.Size] = 35;

            var square = factory.GetShape(WidgetsAvailable.Square, info);
            Console.WriteLine(square.DrawShape());

            // Elipse Data
            info[(int)WidgetParams.StartX] = 100;
            info[(int)WidgetParams.StartY] = 150;
            info[(int)WidgetParams.Width] = 300;
            info[(int)WidgetParams.Height] = 200;

            var elipse = factory.GetShape(WidgetsAvailable.Elipse, info);
            Console.WriteLine(elipse.DrawShape());

            // Circle Data
            info[(int)WidgetParams.StartX] = 1;
            info[(int)WidgetParams.StartY] = 1;
            info[(int)WidgetParams.Size] = 300;

            var circle = factory.GetShape(WidgetsAvailable.Circle, info);
            Console.WriteLine(circle.DrawShape());

            // TextBox Data
            info[(int)WidgetParams.StartX] = 5;
            info[(int)WidgetParams.StartY] = 5;
            info[(int)WidgetParams.Width] = 200;
            info[(int)WidgetParams.Height] = 100;

            var text = "Sample Text";

            var textBox = factory.GetShape(WidgetsAvailable.TextBox, info, text);
            Console.WriteLine(textBox.DrawShape());

            Console.ReadLine();
        }
    }
}
