namespace inheritShit
{
    public class animal
    {
        public string name { get; set; }
        public double height { get; set; }
        public double length{ get; set; }
        public double weight { get; set; }
        public int age { get; set; }

        public animal(string name, double height, double length, double weight, int age)
        {
            this.name = name;
            this.height = height;
            this.length = length;
            this.weight = weight;
            this.age = age;
        }
        
        
    }
    
    
}