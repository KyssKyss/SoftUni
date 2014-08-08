using System;

namespace NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        //TODO: Ex.8 Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
        //Note that you may need to use a for-loop. Examples:
        //numbers	sum
        //    3	    1
        //          2
        //          3
        //or
        //numbers	sum
        //    5	    1
        //          2
        //          3
        //          4
        //          5
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            string numberReader = Console.ReadLine();
            int number = 0;
            if (int.TryParse(numberReader, out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("The sum: {0}", i);
                }                
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
