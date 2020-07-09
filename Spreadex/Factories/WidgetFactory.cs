using System;
using Spreadex.Shapes;
using Spreadex.Shapes.Enums;
using Spreadex.Shapes.Interfaces;

namespace Spreadex.Factories
{
    public class WidgetFactory
    {
        public Func<int[], IBasicShape>[] ShapesAvailable = 
        {
            GetRectangle,
            GetSquare,
            GetElipse,
            GetCircle
        };

        public IBasicShape GetShape(WidgetsAvailable widgetId, int[] info, string text = "")
        {
            return widgetId == WidgetsAvailable.TextBox ? GetTextBox(text, info) : ShapesAvailable[(int)widgetId](info);
        }

        private static IBasicShape GetRectangle(params int[] info)
        {
            var shape = new Rectangle(info[(int)WidgetParams.StartX], info[(int)WidgetParams.StartY])
            {
                Width = info[(int)WidgetParams.Width],
                Height = info[(int)WidgetParams.Height]
            };

            return shape;
        }

        private static IBasicShape GetSquare(params int[] info)
        {
            var shape = new Square(info[(int) WidgetParams.StartX], info[(int) WidgetParams.StartY])
            {
                Size = info[(int)WidgetParams.Size]
            };

            return shape;
        }

        private static IBasicShape GetElipse(params int[] info)
        {
            var shape = new Elipse(info[(int)WidgetParams.StartX], info[(int)WidgetParams.StartY])
            {
                DiameterX = info[(int)WidgetParams.Width],
                DiameterY = info[(int)WidgetParams.Height]
            };

            return shape;
        }

        private static IBasicShape GetCircle(params int[] info)
        {
            var shape = new Circle(info[(int)WidgetParams.StartX], info[(int)WidgetParams.StartY])
            {
                Diameter = info[(int)WidgetParams.Size]
            };

            return shape;
        }

        private static IBasicShape GetTextBox(string text, params int[] info)
        {
            var canvas = GetRectangle(info) as Rectangle;

            var shape = new TextBox(canvas)
            {
                Text = text
            };

            return shape;
        }
    }
}