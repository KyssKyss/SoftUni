using System;

namespace NumberFromOneToN
{
    class NumberFromOneToN
    {
        //TODO: Ex.1 Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
        //on a single line, separated by a space. Examples:
        //n	    output
        //3	    1 2 3
        //5	    1 2 3 4 5
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Input a positive integer:");
                string numberReader = Console.ReadLine();
                int number = 0;
                if (int.TryParse(numberReader, out number))
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Console.Write("{0} ", i);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                    Console.WriteLine(new string('-', Console.WindowWidth)); // separate inputs by dashes
                }
            }            
        }
    }
}
