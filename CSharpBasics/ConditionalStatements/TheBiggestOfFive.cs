using System;

namespace TheBiggestOfFive
{
    class TheBiggestOfFive
    {
        //TODO: Ex.6 Write a program that finds the biggest of five numbers by using only five if statements. Examples:
        //a	    b	    c	    d	    e	    biggest
        //5	    2	    2	    4	    1	    5
        //-2	-22	    1	    0	    0	    1
        //-2	4	    3	    2	    0	    4
        //0	    -2.5	0	    5	    5	    5
        //-3	-0.5	-1.1	-2	    -0.1	-0.1
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter the 1st number");
                string firstNumberReader = Console.ReadLine();
                float firstNumber = 0;
                Console.WriteLine("Please enter the 2nd number");
                string secondNumberReader = Console.ReadLine();
                float secondNumber = 0;
                Console.WriteLine("Please enter the 3rd number");
                string thirdNumberReader = Console.ReadLine();
                float thirdNumber = 0;
                Console.WriteLine("Please enter the 4th number");
                string fourthNumberReader = Console.ReadLine();
                float fourthNumber = 0;
                Console.WriteLine("Please enter the 5th number");
                string fifthNumberReader = Console.ReadLine();
                float fifthNumber = 0;
                float biggestNumber = 0;
                if (float.TryParse(firstNumberReader, out firstNumber) && float.TryParse(secondNumberReader, out secondNumber)
                    && float.TryParse(thirdNumberReader, out thirdNumber) && float.TryParse(fourthNumberReader, out fourthNumber)
                    && float.TryParse(fifthNumberReader, out fifthNumber))
                {
                    biggestNumber = firstNumber;
                    if (secondNumber > biggestNumber)
                    {
                        biggestNumber = secondNumber;
                    }
                    if (thirdNumber > biggestNumber)
                    {
                        biggestNumber = thirdNumber;
                    }
                    if (fourthNumber > biggestNumber)
                    {
                        biggestNumber = fourthNumber;
                    }
                    if (fifthNumber > biggestNumber)
                    {
                        biggestNumber = fifthNumber;
                    }         
                    Console.WriteLine("The biggest number is {0}", biggestNumber);
                    Console.WriteLine(new string('-',Console.WindowWidth)); // add slash separator
                }
            }            
        }
    }
}
