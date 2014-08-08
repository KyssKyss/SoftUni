using System;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        //TODO: Ex.3 Write a program that reads the radius r of a circle and prints its perimeter and 
        //area formatted with 2 digits after the decimal point.
        //Examples:
        //r	    perimeter	area
        //2	    12.57	    12.57
        //3.5	21.99	    38.48
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a radius of the circle:");
                string radiusReader = Console.ReadLine();
                float radius = 0;
                if (float.TryParse(radiusReader, out radius))
                {
                    double area = Math.PI * Math.Pow(radius, 2);
                    double perimeter = 2 * Math.PI * radius;
                    Console.WriteLine("The perimeter of the circle is {0:F2} and the area - {0:F2}", perimeter, area);
                }
                else
                {
                    Console.WriteLine("Please enter a correct input!");
                }
            }
        }
    }
}
