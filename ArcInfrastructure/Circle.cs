using System;
using System.Collections.Generic;
using System.Text;

namespace ArcInfrastructure
{
    static class Circle 
    {

        public static int dimensions = 1;
        public static string text1 = "Radius";
        public static string text2 = "";
        public static double calculateArea(double r)
        {
            return 3.14 * r * r;
        }

    }
}
