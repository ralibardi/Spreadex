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
            GetRectangle();

            // Square Data
            GetSquare();

            // Elipse Data
            GetElipse();

            // Circle Data
            GetCircle();

            // TextBox Data
            GetTextBox();

            Console.ReadLine();
        }

        private static void GetRectangle()
        {
            var info = new int[5]; // this array is created to standardize all factories to one input

            // Rectangle Data
            info[(int)WidgetParams.StartX] = 10;
            info[(int)WidgetParams.StartY] = 10;
            info[(int)WidgetParams.Width] = 30;
            info[(int)WidgetParams.Height] = 40;

            var factory = new RectangleFactory(info);

            factory.GetShape().DrawShape();
            Console.WriteLine();
        }

        private static void GetSquare()
        {
            var info = new int[5];

            // Square Data
            info[(int)WidgetParams.StartX] = 15;
            info[(int)WidgetParams.StartY] = 30;
            info[(int)WidgetParams.Size] = 35;

            var factory = new SquareFactory(info);

            factory.GetShape().DrawShape();
            Console.WriteLine();
        }

        private static void GetElipse()
        {
            var info = new int[5];

            // Elipse Data
            info[(int)WidgetParams.StartX] = 100;
            info[(int)WidgetParams.StartY] = 150;
            info[(int)WidgetParams.Width] = 300;
            info[(int) WidgetParams.Height] = 200;

            var factory = new ElipseFactory(info);

            factory.GetShape().DrawShape();
            Console.WriteLine();
        }

        private static void GetCircle()
        {
            var info = new int[5];

            // Circle Data
            info[(int)WidgetParams.StartX] = 1;
            info[(int)WidgetParams.StartY] = 1;
            info[(int)WidgetParams.Size] = 300;

            var factory = new CircleFactory(info);

            factory.GetShape().DrawShape();
            Console.WriteLine();
        }

        private static void GetTextBox()
        {
            var info = new int[5];

            // TextBox Data
            info[(int)WidgetParams.StartX] = 5;
            info[(int)WidgetParams.StartY] = 5;
            info[(int)WidgetParams.Width] = 200;
            info[(int)WidgetParams.Height] = 100;

            const string text = "Sample Text";

            var factory = new TextBoxFactory(info, text);

            factory.GetShape().DrawShape();
            Console.WriteLine();
        }
    }
}
