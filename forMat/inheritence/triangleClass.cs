namespace inheritence
{
    public class triangleClass : basicShit
    {
        public triangleClass(int height, int width, string color, int xCoordinate, int yCoordinate) : base(height, width, color, xCoordinate, yCoordinate)
        {
     
        }
        
        
        public double Area(int height, int width)
        {
            double result = height * width / 2;
            
            return result;
        }

        public double Circum(int height, int width)
        {
            double result = ((height * 2) + (width * 2) / 2);
            
            return result;
        }
    }
}
