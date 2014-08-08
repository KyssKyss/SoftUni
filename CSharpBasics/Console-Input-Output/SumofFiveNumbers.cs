using System;

namespace SumofFiveNumbers
{
    class SumofFiveNumbers
    {
        //TODO: Ex.7 Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
        //Examples:
        //numbers	            sum
        //1 2 3 4 5	            15
        //10 10 10 10 10	    50
        //1.5 3.14 8.2 -1 0	    11.84
        static void Main()
        {
            Console.WriteLine("Write the number sequence");
            string sequence = Console.ReadLine();
            string[] collection = sequence.Split(' ');
            float result = 0;
            foreach (var str in collection)
            {
                result += float.Parse(str);
            }
            Console.WriteLine("The sum is {0}.", result);
        }
    }
}
