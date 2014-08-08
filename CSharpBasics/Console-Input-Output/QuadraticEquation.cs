using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        //TODO: Ex.6 Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
        //and solves it (prints its real roots). Examples:
        //a	    b	c	roots
        //2	    5	-3	x1=-3; x2=0.5
        //-1	3	0	x1=3; x2=0
        //-0.5	4	-8	x1=x2=4
        //5	    2	8	no real roots

        static void Main()
        {
            Console.WriteLine("Write coefficient a:");
            string aReader = Console.ReadLine();
            float a = 0;
            Console.WriteLine("Write coefficient b:");
            string bReader = Console.ReadLine();
            float b = 0; 
            Console.WriteLine("Write coefficient c:");
            string cReader = Console.ReadLine();
            float c = 0;
            float result = 0;
            double firstRoot = 0;
            double secondRoot = 0;
            if (float.TryParse(aReader, out a) && float.TryParse(bReader, out b) && float.TryParse(cReader, out c))
            {
                if (a == 0)
                {
                    if (b == 0)
	                {
                        Console.WriteLine("Can't have both 'a' and 'c' with zero value!");
	                }
                    result = -(c / b);
                    Console.WriteLine("Not a quadratic equation! X = {0}",result);
                }
                else
                {
                    if (b == 0)
                    {
                        firstRoot = -(Math.Sqrt(-4 * a * c) / 2 * a);
                        secondRoot = (Math.Sqrt(-4 * a * c) / 2 * a);
                    }
                    else
                    {
                        firstRoot = (-b + (Math.Sqrt((b*b) - (4 * a * c)))) / (2 * a);
                        secondRoot = (-b - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
                        Console.WriteLine("The firts real root is {0}\r\nand the second is {1}.", firstRoot, secondRoot);
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
