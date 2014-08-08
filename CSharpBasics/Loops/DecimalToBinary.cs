using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        //TODO: Ex.14 Using loops write a program that converts an integer number to its binary representation. 
        //The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.
        //Examples:
        //decimal	    binary
        //0	        0
        //3	        11
        //43691	    1010101010101011
        //236476736	1110000110000101100101000000
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter a number:");
                long decimalNumber = long.Parse(Console.ReadLine());
                string str = null;
                while (decimalNumber > 0)
                {
                    if (decimalNumber % 2 != 0)
                    {
                        str += 1;
                        decimalNumber /= 2;
                    }
                    else
                    {
                        str += 0;
                        decimalNumber /= 2;
                    }
                }
                char[] result = str.ToCharArray();
                Array.Reverse(result);
                Console.WriteLine("To binary:");
                Console.WriteLine(result);
                Console.WriteLine(new string('-', Console.WindowWidth)); //separate results by dashes
            }            
        }
    }
}
