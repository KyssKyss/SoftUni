using System;
using System.Numerics;

namespace PrimeChecker
{
    class PrimeChecker
    {
        //TODO: Ex.2 Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. Examples:
        //n	            IsPrime(n)
        //0	            false
        //1	            false
        //2	            true
        //3	            true
        //4	            false
        //5	            true
        //323	        false
        //337	        true
        //6737626471    true
        //117342557809	false
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write a integer number");
                string nReader = Console.ReadLine();
                long n = 0;
                if (long.TryParse(nReader, out n))
                {
                    Console.WriteLine(IsPrime(n));
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }            
        }
        static bool IsPrime(double number)
        {
            bool isPrime = true;
            double i = 2;
            if (number > 0)
            {
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                    i++;
                }
            }
            else
            {
                isPrime = false;
            }
            Console.WriteLine(); 
            return isPrime;         
        }
    }
}
