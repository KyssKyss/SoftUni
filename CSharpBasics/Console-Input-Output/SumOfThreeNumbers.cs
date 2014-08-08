using System;

namespace SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        //TODO: Ex.1 Write a program that reads 3 real numbers from the console and prints their sum. Examples:
        //a   b   c       sum
        //3   4   11      18
        //-2  0   3       1
        //5.5 4.5 20.1    30.1
        static void Main()
        {
            Console.WriteLine("Write a number a:");
            float numberA = float.Parse(Console.ReadLine());
            Console.WriteLine("Write a number b:");
            float numberB = float.Parse(Console.ReadLine());
            Console.WriteLine("Write a number c:");
            float numberC = float.Parse(Console.ReadLine());
            float sum = numberA + numberB + numberC;
            Console.WriteLine("{0} + {1} + {2} = {3}", numberA, numberB, numberC, sum);
        }
    }
}
