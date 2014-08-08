using System;
using System.Numerics;

namespace CalculateNumberOfCombinations
{
    class CalculateNumberOfCombinations
    {
        //TODO: Ex. 7 In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations)
        //is calculated by the following formula: For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
        //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. Examples:
        //n	    k	n! / (k! * (n-k)!)
        //3	    2	    3
        //4	    2	    6
        //10 	6	    210
        //52	5	    2598960
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write a 'n' number:");
                string nReader = Console.ReadLine();
                Console.WriteLine("Write a 'k' number:");
                string kReader = Console.ReadLine();
                int n = 0;
                int k = 0;
                if (int.TryParse(nReader, out n) && int.TryParse(kReader, out k))
                {
                    BigInteger result = 1;
                    BigInteger factN = 1;
                    BigInteger factK = 1;
                    for (int i = k + 1; i <= n; i++)
                    {
                        factN *= i;
                    }
                    for (int j = 1; j <= n - k; j++)
                    {
                        factK *= j;
                    }
                    result = factN / factK;
                    Console.WriteLine("The result is {0}", result);
                    Console.WriteLine(); 
                }           
            }            
        }
    }
}
