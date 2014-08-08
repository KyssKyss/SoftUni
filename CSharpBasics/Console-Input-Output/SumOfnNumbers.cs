using System;

namespace SumOfnNumbers
{
    class SumOfnNumbers
    {
        //TODO: Ex.9 Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
        //Note that you may need to use a for-loop. Examples:
        // numbers  sum
        // 3           
        // 20       90
        // 60
        // 10	     
        //or
        // numbers	sum
        // 5
        // 2        6.5
        // -1
        // -0.5
        // 4
        // 2
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter a number");
                string numberReader = Console.ReadLine();
                int number = 0;
                long sum = 0;
                if (int.TryParse(numberReader, out number))
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine("Enter {0} number:", i);
                        sum += int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("The sum of all {0} number is {1}.", number, sum);
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }
            }            
        }
    }
}
