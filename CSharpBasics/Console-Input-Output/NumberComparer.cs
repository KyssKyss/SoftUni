using System;

namespace NumberComparer
{
    class NumberComparer
    {
        //TODO: Ex.4 Write a program that gets two numbers from the console and prints the greater of them.
        //Try to implement this without if statements. Examples:
        //a	    b	greater
        //5	    6	6
        //10	5	10
        //0	    0	0
        //-5	-2	-2
        //1.5	1.6	1.6
        static void Main()
        {
            Console.WriteLine("Please write the first number:");
            string firstNumberReader = Console.ReadLine();
            float firstNumber = 0;
            Console.WriteLine("Next, input the second number:");
            string secondNumberReader = Console.ReadLine();
            float secondNumber = 0;
            if (float.TryParse(firstNumberReader, out firstNumber) && float.TryParse(secondNumberReader, out secondNumber))
            {
                while (firstNumber > secondNumber)
                {
                    Console.WriteLine("The biger number is {0}", firstNumber);
                    return;
                }
                Console.WriteLine("The biger number is {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("Write a valid inputs!");
            }
        }
    }
}
