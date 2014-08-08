using System;

namespace CalculateToFactNOverX
{
    class Program
    {
        //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
        //Use only one loop. Print the result with 5 digits after the decimal point. Example:
        //n	    x	    S
        //3	    2	    2.75000
        //4	    3	    2.07407
        //5	    -4	    0.75781
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1;
            decimal factN = 1;
            decimal result = 1; 
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                result *= x;
	            sum += (factN / result);       
            }
            Console.WriteLine("{0:F5}",sum);
        }
    }
}
