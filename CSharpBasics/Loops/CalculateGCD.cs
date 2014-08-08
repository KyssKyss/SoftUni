using System;

namespace CalculateGCD
{
    class CalculateGCD
    {
        //TODO: Ex.17 Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
        //Use the Euclidean algorithm (find it in Internet). Examples:
        //a	    b	    GCD(a, b)
        //3	    2	    1
        //60	40	    20
        //5	    -15	    5
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write the first integer a:");
                string aReader = Console.ReadLine();
                int a = 0;
                Console.WriteLine("Write the second integer b:");
                string bReader = Console.ReadLine();
                int b = 0;
                int temp = 0;
                if (int.TryParse(aReader, out a) && int.TryParse(bReader, out b))
                {
                    while (a != 0)
                    {
                        temp = a;
                        a = a % b;
                        b = temp;
                    }
                    Console.WriteLine("The GCD is: {0}", b);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }            
        }
    }
}
