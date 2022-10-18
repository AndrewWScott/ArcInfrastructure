using System;
using System.Collections.Generic;
using System.Text;

namespace ArcInfrastructure
{
    static class Rectangle
    {

        public static int dimensions = 2;
        public static string text1 = "Width";
        public static string text2 = "Height";
        public static double calculateArea(double width, double height)
        {
            return width * height;
        }
    }
}
