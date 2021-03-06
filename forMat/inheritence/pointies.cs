using System;
using System.Collections;

namespace inheritence
{
    public class pointies : basicShit
    {
        public pointies(int height, int width, string color, int xCoordinate, int yCoordinate) : base(height, width, color, xCoordinate, yCoordinate)
        {
            
        }

        public double Area(int height, int width)
        {
            double result = height * width;
            
            return result;
        }

        static double Circum(int height, int width)
        {
            int result = (height * 2) + (width * 2);
            
            return result;
        }
    }
}
