using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        //TODO: Ex. 8 In combinatorics, the Catalan numbers are calculated by the following formula:
        //C_n = \frac{1}{n+1}{2n\choose n} 
        //Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
        //n	    Catalan(n)
        //0	    1
        //5	    42
        //10	16796
        //15	9694845
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a 'n': ");
                string nReader = Console.ReadLine();
                int n = 0;
                BigInteger factN = 1;
                BigInteger factTwoPowerN = 1;
                BigInteger factNPlusOne = 1;
                BigInteger result = 0;
                if (int.TryParse(nReader, out n))
                {
                    if (n > 1 && n < 100)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            factN *= i;
                        }
                        for (int i = 1; i <= 2 * n; i++)
                        {
                            factTwoPowerN *= i;
                        }
                        for (int i = 1; i <= n + 1; i++)
                        {
                            factNPlusOne *= i;
                        }
                        result = factTwoPowerN / (factNPlusOne * factN);
                        Console.WriteLine("The result is {0}", result);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 1 and 100");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a number between 1 and 100");
                }            
            }            
        }
    }
}
//
