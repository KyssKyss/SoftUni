using System;
using System.Numerics;

namespace TrailingZeroes
{
    class TrailingZeroes
    {
        //TODO: EX. 18 Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
        //Your program should work well for very big numbers, e.g. n=100000. Examples:
        //n	    trailing zeroes of n!	    explaination
        //10	    2	                    3628800
        //20	    4	                    2432902008176640000
        //100000	24999	                think why
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                long n = long.Parse(Console.ReadLine());
                BigInteger result = 1;
                int counter = 0;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                BigInteger reminder = 0;
                while (result > 0)
                {
                    reminder = result % 10;
                    if (reminder == 0)
                    {
                        counter++;
                        result /= 10;
                    }
                    else
                    {
                        result /= 10;
                        break;
                    }
                }
                Console.WriteLine(counter);
            }            
        }
    }
}
