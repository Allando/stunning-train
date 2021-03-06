using System;

namespace polyShit
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClass car1 = new CarClass("shit", "shit",1);
            CarClass car2 = new CarClass("not shit", "not shit", 9001);
            CarClass car3 = new CarClass("asd", "dsa", 444);
            
            
            /* In case you need user input to move the shape
            Set the base coordinates to two gives values, x and y.
            For this example, the default values will be at 100 - so x = 100 and y = 100.
            After the these varibles for x and y is set. ask the user for their input,
            including the start position of the, while reminding them of the option 
            of having these be empty, where it will default to x=100 and y=100
            */

            int coordinateX = 100;
            int coordinateY = 100;

            Console.WriteLine("Insert X coordinate (current at 100)");
            coordinateX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert Y coordinate (current at 100)");
            coordinateY = Convert.ToInt32(Console.ReadLine());
        }
    }
}
