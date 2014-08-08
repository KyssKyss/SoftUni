using System;

namespace CalculateFactorialNDevideByFactorialK
{
    class CalculateFactorialNDevideByFactorialK
    {
        //TODO: Ex. 6 Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.
        //Examples:
        //n	    k	n! / k!
        //5	    2	60
        //6	    5	6
        //8	    3	6720
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            decimal result = 1;
            decimal factN = 1;
            for (int i = k + 1; i <= n; i++)
            {
                factN *= i;
                result = factN;
            }
            Console.WriteLine(result);
        }
    }
}
