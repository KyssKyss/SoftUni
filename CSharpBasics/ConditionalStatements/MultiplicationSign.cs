using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        //TODO: Ex.4 Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        //Use a sequence of if operators. Examples:
        //a	    b	    c	    result
        //5	    2	    2	    +
        //-2	-2	    1	    +
        //-2	4	    3	    -
        //0	    -2.5	4	    0
        //-1	-0.5	-5.1	-
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
                Console.WriteLine("Write the third number:");
                string thirdNumberReader = Console.ReadLine();
                float thirdNumber = 0;
                string result = null;
                if (float.TryParse(firstNumberReader, out firstNumber) && float.TryParse(secondNumberReader, out secondNumber)
                    && float.TryParse(thirdNumberReader, out thirdNumber))
                {
                    if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
                    {
                        result = "+";
                    }
                    else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
                    {
                        result = "0";
                    }
                    else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
                    {
                        if (firstNumber > 0 && secondNumber > 0 || firstNumber > 0 && thirdNumber > 0 || secondNumber > 0 && thirdNumber > 0 )
                        {
                            result = "-";
                        }
                        else if (firstNumber > 0 || secondNumber > 0 || thirdNumber > 0)
                        {
                            result = "+";
                        }
                        else
                        {
                            result = "-";
                        }
                    }
                    else
                    {
                        result = "-";
                    }
                }
                Console.WriteLine("The result is: {0}", result);
                Console.WriteLine(new string('-', Console.WindowWidth)); //split the results with dashes
            }            
        }
    }
}
