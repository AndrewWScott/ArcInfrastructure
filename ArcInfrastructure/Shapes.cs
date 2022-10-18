using System;
using System.Collections.Generic;
using System.Text;

namespace ArcInfrastructure
{
    static class Shapes
    {

        public enum Shape
        {
            Circle,
            Square,
            Rectangle
        }

        public static double calculate(Shapes.Shape Shape, double dOne, double dTwo)
        {
            switch (Shape)
            {
                case Shapes.Shape.Circle:
                    return Circle.calculateArea(dOne);
                case Shapes.Shape.Rectangle:
                    return Rectangle.calculateArea(dOne, dTwo);
                case Shapes.Shape.Square:
                    return Square.calculateArea(dOne);
                default:
                    return 0;
            }
        }

        public static void getSettings(Shape shape, ref int dimensions, ref string text1, ref string text2)
        {

            switch (shape)
            {
                case Shapes.Shape.Circle:
                    dimensions = Circle.dimensions;
                    text1 = Circle.text1;
                    text2 = Circle.text2;
                    break;
                case Shapes.Shape.Rectangle:
                    dimensions = Rectangle.dimensions;
                    text1 = Rectangle.text1;
                    text2 = Rectangle.text2;
                    break;
                case Shapes.Shape.Square:
                    dimensions = Square.dimensions;
                    text1 = Square.text1;
                    text2 = Square.text2;
                    break;
                default:
                    dimensions = 0;
                    text1 = "";
                    text2 = "";
                    break;
            }
        }

    }
}
