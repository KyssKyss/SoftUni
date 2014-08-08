using System;

namespace BiggestOfThree
{
    class BiggestOfThree
    {
        //TODO: Ex.5 Write a program that finds the biggest of three numbers. Examples:
        //a	    b	    c	    biggest
        //5	    2	    2	    5
        //-2	-2	    1	    1
        //-2	4	    3	    4
        //0	    -2.5	5	    5
        //-0.1	-0.5	-1.1	-0.1
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
                float maximum = 0;
                if (float.TryParse(firstNumberReader, out firstNumber) && float.TryParse(secondNumberReader, out secondNumber)
                    && float.TryParse(thirdNumberReader, out thirdNumber))
                {
                    maximum = firstNumber;
                    if (secondNumber > maximum)
                    {
                        maximum = secondNumber;
                    }
                    if (thirdNumber > maximum)
                    {
                        maximum = thirdNumber;
                    }
                    Console.WriteLine("The maximum number between numbers {0} {1} and {2} is: {3}", firstNumber, secondNumber, thirdNumber, maximum);
                    Console.WriteLine(new string('-', Console.WindowWidth)); // separate with dashes
                }
            }            
        }
    }
}
