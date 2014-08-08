using System;

namespace Trapezoids
{
    class Trapezoids
    {
        //TODO: Ex.9 Write an expression that calculates trapezoid's area by given sides a and b and height h. Examples:
        static void Main()
        {
            Console.Write("Write one side of the trapezoid - A: ");
            float sideA = float.Parse(Console.ReadLine());
            Console.Write("Write one side of the trapezoid - B: ");
            float sideB = float.Parse(Console.ReadLine());
            Console.Write("Write the height of the trapezoid - H: ");
            float h = float.Parse(Console.ReadLine()); ;
            float area = 0.5f * (h) * (sideA + sideB);
            Console.WriteLine("The area of trapezoid is: {0}", area);
        }
    }
}
