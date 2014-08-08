using System;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        //TODO: Ex.5 Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c 
        //and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
        //The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form,
        //padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; 
        //the number c should be printed with 3 digits after the decimal point, left aligned. Examples:
        //a	        b	        c	        result
        //254	    11.6	    0.5	        |FE        |0011111110|     11.60|0.500     |
        //499	    -0.5559	    10000	    |1F3       |0111110011|     -0.56|10000     |
        //0	        3	        -0.1234	    |0         |0000000000|         3|-0.123    |
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write the first Number:");
                string firstNumberReader = Console.ReadLine();
                int firstNumber = 0;
                Console.WriteLine("Write the second one:");
                string secondNumberReader = Console.ReadLine();
                float secondNumber = 0;
                Console.WriteLine("And the third one:");
                string thirdNumberReader = Console.ReadLine();
                float thirdNumber = 0;
                if (int.TryParse(firstNumberReader, out firstNumber) && float.TryParse(secondNumberReader, out secondNumber)
                    && float.TryParse(thirdNumberReader, out thirdNumber))
                {
                    string toHex = Convert.ToString(firstNumber, 16);
                    string toBin = Convert.ToString(firstNumber, 2).PadLeft(10, '0');
                    Console.WriteLine("|{0,-10}|{1}|{2,10}|{3,-10:F3}|", toHex, toBin, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }
                Console.WriteLine(new string('-',Console.WindowWidth)); // set dashes to divide the cycles
            }            
        }
    }
}
