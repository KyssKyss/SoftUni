using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        //TODO: Ex.9 Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
        //like in the examples below. Use two nested loops. Examples:
        //n	    matrix
        //2	    1 2
        //      2 3
        //n	    matrix
        //3	    1 2 3
        //      2 3 4
        //      3 4 5
        //n	matrix
        //4	    1 2 3 4
        //      2 3 4 5
        //      3 4 5 6
        //      4 5 6 7
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter a n number's of positive integers");
                string nReader = Console.ReadLine();
                int n = 0;
                if (int.TryParse(nReader, out n))
                {
                    if (n >= 1 && n <= 20)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = i; j < n + i; j++)
                            {
                                Console.Write("{0,3} ", j);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("The number should be between 1 and 20!");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a number between 1 and 20!");
                }           
            }            
        }
    }
}
