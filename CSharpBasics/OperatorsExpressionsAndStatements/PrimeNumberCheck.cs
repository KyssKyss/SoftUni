using System;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        //TODO: Ex.8 Write an expression that checks if given positive integer number n (n ≤ 100) is prime
        //(i.e. it is divisible without remainder only to itself and 1). Examples:
        //n	Prime?
        //1	    false
        //2	    true
        //3 	true
        //4	    false
        //9	    false
        //97	true
        //51	false
        //-3	false
        //0	    false
        static void Main()
        {
            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int i = 2;
            if (number > 0)
            {
                while (i <= number / 2)
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
            Console.WriteLine("{0}\t{1}", number, isPrime);
        }
    }
}
