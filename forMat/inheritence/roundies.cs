using System;

namespace inheritence
{
    public class roundies : basicShit
    {
        public roundies(int height, int width, string color, int xCoordinate, int yCoordinate) : base(height, width, color, xCoordinate, yCoordinate)
        {
        }
        
        public double Area(int width)
        {
            double result = width * Math.PI;
            
            return result;
        }

        static double Circum(int width)
        {
            double result = 2 * Math.PI * (width / 2);
            
            return result;
        }
    }
}
