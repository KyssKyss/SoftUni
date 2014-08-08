using System;

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        //TODO: Ex.11 Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range
        //[min...max]. Examples:
        //n	    min	max	    random numbers
        //5	    0	1	    1 0 0 1 1
        //10	10	15	    12 14 12 15 10 12 14 13 13 11
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write the 'n' numbers: ");
                string nReader = Console.ReadLine();
                Console.WriteLine("Min value: ");
                string minReader = Console.ReadLine();
                Console.WriteLine("Max value: ");
                string maxReader = Console.ReadLine();
                int n = 0;
                int maxNumber = 0;
                int minNumber = 0;
                Random rnd = new Random();
                if (int.TryParse(nReader, out n) && int.TryParse(minReader, out minNumber) && int.TryParse(maxReader, out maxNumber))
                {
                    for (int i = 0; i < n; i++)
                    {
                        int result = rnd.Next(minNumber, maxNumber + 1);
                        Console.Write("{0} ", result);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();           
            }            
        }
    }
}
