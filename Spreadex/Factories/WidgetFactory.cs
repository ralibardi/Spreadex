using System;
using Spreadex.Shapes;
using Spreadex.Shapes.Enums;
using Spreadex.Shapes.Interfaces;

namespace Spreadex.Factories
{
    public class WidgetFactory
    {
        public static IBasicShape GetShape(WidgetsAvailable widgetId, int startX, int startY, int width = 0, int height = 0, string text = "")
        {
            switch (widgetId)
            {
                case WidgetsAvailable.Rectangle:
                    return GetRectangle(startX, startY, width, height);

                case WidgetsAvailable.Square:
                    return GetSquare(startX, startY, width);

                case WidgetsAvailable.Elipse:
                    return GetElipse(startX, startY, width, height);

                case WidgetsAvailable.Circle:
                    return GetCircle(startX, startY, width);

                case WidgetsAvailable.TextBox:
                    return GetTextBox(startX, startY, width, height, text);

                default:
                    throw new ArgumentOutOfRangeException(nameof(widgetId), widgetId, Resources.WidgetNotSupported);
            }
        }

        private static IBasicShape GetRectangle(int startX, int startY, int width, int height)
        {
            var shape = new Rectangle(startX, startY)
            {
                Width = width,
                Height = height
            };

            return shape;
        }

        private static IBasicShape GetSquare(int startX, int startY, int size)
        {
            var shape = new Square(startX, startY)
            {
                Size = size
            };

            return shape;
        }

        private static IBasicShape GetElipse(int startX, int startY, int diameterH, int diameterV)
        {
            var shape = new Elipse(startX, startY)
            {
                DiameterX = diameterH,
                DiameterY = diameterV
            };

            return shape;
        }

        private static IBasicShape GetCircle(int startX, int startY, int size)
        {
            var shape = new Circle(startX, startY)
            {
                Diameter = size
            };

            return shape;
        }

        private static IBasicShape GetTextBox(int startX, int startY, int width, int height, string text)
        {
            var shape = new TextBox(startX, startY)
            {
                Width = width,
                Height = height,
                Text = text
            };

            return shape;
        }
    }
}