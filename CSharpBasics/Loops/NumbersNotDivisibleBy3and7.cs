using System;

namespace NumbersNotDivisibleBy3and7
{
    class NumbersNotDivisibleBy3and7
    {
        //TODO: Ex.2 Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n 
        //not divisible by 3 and 7, on a single line, separated by a space. Examples:
        //n	    output
        //3	    1 2
        //10	1 2 4 5 8 10
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
                        if (i % 3 == 0 || i % 7 == 0)
                        {
                           continue; 
                        }
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
