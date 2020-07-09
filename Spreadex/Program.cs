using System;
using Spreadex.Factories;
using Spreadex.Shapes.Enums;

namespace Spreadex
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Rectangle Data
            var startX = 10;
            var startY = 10;
            var width = 30;
            var height = 40;

            var rectangle = WidgetFactory.GetShape(WidgetsAvailable.Rectangle, startX, startY, width, height);
            Console.WriteLine(rectangle.DrawShape());

            // Square Data
            startX = 15;
            startY = 30;
            var size = 35;

            var square = WidgetFactory.GetShape(WidgetsAvailable.Square, startX, startY, size);
            Console.WriteLine(square.DrawShape());

            // Elipse Data
            startX = 100;
            startY = 150;
            width = 300;
            height = 200;

            var elipse = WidgetFactory.GetShape(WidgetsAvailable.Elipse, startX, startY, width, height);
            Console.WriteLine(elipse.DrawShape());

            // Circle Data
            startX = 1;
            startY = 1;
            size = 300;

            var circle = WidgetFactory.GetShape(WidgetsAvailable.Circle, startX, startY, size);
            Console.WriteLine(circle.DrawShape());

            // TextBox Data
            startX = 5;
            startY = 5;
            width = 200;
            height = 100;
            var text = "Sample Text";

            var textBox = WidgetFactory.GetShape(WidgetsAvailable.TextBox, startX, startY, width, height, text);
            Console.WriteLine(textBox.DrawShape());

            Console.ReadLine();
        }
    }
}
