using System;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        //TODO: Ex. 13 Using loops write a program that converts a binary integer number to its decimal form. 
        //The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 
        //Examples:
        //binary	                        decimal
        //0	                                0
        //11	                            3
        //1010101010101011	                43691
        //1110000110000101100101000000	    236476736
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter a number in binary form:");
                char[] str = Console.ReadLine().ToCharArray();
                Array.Reverse(str);
                double result = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    int binary = int.Parse(str[i].ToString());
                    result += binary * Math.Pow(2, i);
                }
                Console.WriteLine(result);
            }           
        }
    }
}
