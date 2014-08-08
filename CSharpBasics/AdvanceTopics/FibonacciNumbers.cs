using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        //TODO: Ex.1 Define a method Fib(n) that calculates the nth Fibonacci number. Examples:
        //n	    Fib(n)
        //0	    1
        //1	    1
        //2	    2
        //3	    3
        //4	    5
        //5	    8
        //6	    13
        //11	144
        //25	121393
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write a number sequence 'n': ");
                string nReader = Console.ReadLine();
                int n = 0;
                if (int.TryParse(nReader, out n))
                {
                    Fib(n);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }            
        }
        static void Fib(int n)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 1;
            decimal temp = 1;
            for (int i = 0; i < n; i++)
            {                
                temp = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = temp;                            
            }
            Console.WriteLine(temp);
        }
    }
}
