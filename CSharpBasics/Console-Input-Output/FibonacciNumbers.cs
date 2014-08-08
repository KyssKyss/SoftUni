using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        //TODO: Ex.10 Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
        //(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
        //Note that you may need to learn how to use loops. Examples:
        //n	comments
        //1	0
        //3	0 1 1
        //10	0 1 1 2 3 5 8 13 21 34
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a 'n' numbers:");
                string numberReader = Console.ReadLine();
                int numberN = 0;
                int firstNumber = 0;
                int secondNumber = 1;
                int thirdNumber = 0;
                if (int.TryParse(numberReader, out numberN))
                {
                    for (int i = 0; i < numberN; i++)
                    {
                        Console.Write("{0} ", firstNumber);
                        thirdNumber = firstNumber + secondNumber;
                        firstNumber = secondNumber;
                        secondNumber = thirdNumber;
                    }
                    Console.WriteLine();
                    Console.WriteLine(new string('-',Console.WindowWidth)); // split with dashes inputs
                } 
            }            
        }
    }
}
