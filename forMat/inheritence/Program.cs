using System;

namespace inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            int x_coordinate = 100;
            int y_coordinate = 100;
            int width = 0;
            int height = 0;
            int choice;
            string color = "ya mom";

            calcClass calccccc = new calcClass();
            
            Console.WriteLine("Insert x coordinate (default is 100)");
            x_coordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert x coordinate (default is 100)");
            y_coordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1) Circle 2) Rectangle");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                roundies circle = new roundies(height, width, color, x_coordinate, y_coordinate);
                //DrawEllipse (circle.color, circle.X_Coordinate, circle.Y_Coordinate, circle.width, circle.height);
            }
            else if (choice == 2)
            {
                pointies rectangle = new pointies (height, width, color, x_coordinate, y_coordinate);
                
                Console.WriteLine(rectangle.Area(rectangle.height, rectangle.width));
                calccccc.CircumRectangle(rectangle.height, rectangle.width);
                //DrawEllipse (rectangle.color, rectangle.X_Coordinate, rectangle.Y_Coordinate, rectangle.width, rectangle.height);
            }
            else
            {
                Console.WriteLine("stop");
            }

            
        }
    }
}
