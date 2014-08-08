using System;

namespace ExchangeValues
{
    class ExchangeValues
    {
        //TODO: Ex.1 Write an if-statement that takes two integer variables a and b and exchanges their values
        //if the first one is greater than the second one. As a result print the values a and b, separated by a space. Examples:
        //a	    b	    result
        //5	    2	    2   5
        //3	    4	    3   4
        //5.5	4.5	    4.5 5.5
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write the first number:");
                string firstNumberReader = Console.ReadLine();
                float firstNumber = 0;
                Console.WriteLine("Write the second number:");
                string secondNumberReader = Console.ReadLine();
                float secondNumber = 0;
                float temp = 0;
                if (float.TryParse(firstNumberReader, out firstNumber) && float.TryParse(secondNumberReader, out secondNumber))
                {
                    if (firstNumber > secondNumber)
                    {
                        temp = secondNumber;
                        secondNumber = firstNumber;
                        firstNumber = temp;
                        Console.WriteLine("{0} {1}", firstNumber, secondNumber);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", firstNumber, secondNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }
            }           
        }
    }
}
