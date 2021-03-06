namespace polyShit
{
    public class CarClass
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public int KmPrLiters { get; set; }

        public CarClass(string make, string color, int kmPrLiters)
        {
            Make = make;
            Color = color;
            KmPrLiters = kmPrLiters;
        }
        
    }
}