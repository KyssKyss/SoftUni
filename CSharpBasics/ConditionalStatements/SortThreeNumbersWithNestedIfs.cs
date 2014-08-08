using System;

namespace SortThreeNumbersWithNestedIfs
{
    class Program
    {
        //TODO: Ex.7 Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements.
        //Don’t use arrays and the built-in sorting functionality. Examples:
        //a	    b	    c	    result
        //5	    1	    2	    5 2 1
        //-2	-2	    1	    1 -2 -2
        //-2	4	    3	    4 3 -2
        //0	    -2.5	5	    5 0 -2.5
        //-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write the 1st number:");
                string firstNumberReader = Console.ReadLine();
                float firstNumber = 0;
                Console.WriteLine("Write the 2nd number:");
                string secondNumberReader = Console.ReadLine();
                float secondNumber = 0;
                Console.WriteLine("Write the 3rd number:");
                string thirdNumberReader = Console.ReadLine();
                float thirdNumber = 0;
                if (float.TryParse(firstNumberReader, out firstNumber) && float.TryParse(secondNumberReader, out secondNumber)
                    && float.TryParse(thirdNumberReader, out thirdNumber))
                {
                    if (firstNumber > secondNumber)
                    {
                        if (firstNumber > thirdNumber)
                        {
                            if (secondNumber > thirdNumber)
                            {
                                Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);   //1,2,3
                            }
                            else
                            {
                                Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);   //1,3,2
                            }
                        }
                        else
                        {
                            Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);   //3,1,2
                        }
                    }
                    else if (firstNumber < secondNumber && secondNumber > thirdNumber)
                    {
                        if (firstNumber > thirdNumber)
                        {
                            Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);   //2,1,3
                        }
                        else
                        {
                            Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);   //2,3,1
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);   //3,2,1
                    }
                    Console.WriteLine(new string('-', Console.WindowWidth)); // separate with dashes
                }
            }
        }
    }
}
