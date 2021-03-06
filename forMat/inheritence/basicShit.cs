namespace inheritence


{
    public class basicShit
    {
        public int height { get; set; }
        public int width { get; set; }
        public string color { get; set; }
        public int X_Coordinate { get; set; }
        public int Y_Coordinate { get; set; }

        public basicShit(int height, int width, string color, int xCoordinate, int yCoordinate)
        {
            this.height = height;
            this.width = width;
            this.color = color;
            X_Coordinate = xCoordinate;
            Y_Coordinate = yCoordinate;
        }
    }
}
