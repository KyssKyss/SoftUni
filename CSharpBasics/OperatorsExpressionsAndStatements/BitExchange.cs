using System;

namespace BitExchange
{
    class BitExchange
    {
        //TODO: Ex.15 Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. Examples:
        //n	            binary representation of n	        binary result	                    result
        //1140867093	01000100 00000000 01000000 00010101	01000010 00000000 01000000 00100101	1107312677
        //255406592	    00001111 00111001 00110010 00000000	00001000 00111001 00110010 00111000	137966136
        //4294901775	11111111 11111111 00000000 00001111	11111001 11111111 00000000 00111111	4194238527
        //5351	        00000000 00000000 00010100 11100111	00000100 00000000 00010100 11000111	67114183
        //2369124121	10001101 00110101 11110111 00011001	10001011 00110101 11110111 00101001	2335569705
        static void Main()
        {
            Console.WriteLine("Write a number n:");
            int n = int.Parse(Console.ReadLine());
            string nToBinary = Convert.ToString(n, 2).PadLeft(32, '0');
            int rightBit = 0;
            int leftBit = 0;
            int result = n;
            int rightBitPosition = 0;
            int leftBitPosition = 0;
            string resultToBinary = "";
            for (int i = 0; i < 3; i++) //loop 3 times with exchanging bits
            {
                Console.WriteLine("Write the right bit:");
                rightBitPosition = int.Parse(Console.ReadLine());
                rightBit = (n >> rightBitPosition) & 1;
                Console.WriteLine("Write the left bit:");
                leftBitPosition = int.Parse(Console.ReadLine());
                leftBit = (n >> leftBitPosition) & 1;
                result = result & (~(1 << leftBitPosition)) | (rightBit << leftBitPosition);
                resultToBinary = Convert.ToString(result, 2).PadLeft(32, '0');
                result = result & (~(1 << rightBitPosition)) | (leftBit << rightBitPosition);                
                resultToBinary = Convert.ToString(result, 2).PadLeft(32, '0');
            }
            Console.WriteLine("n\t\tbinary representation - n\t\t\tbinary result");
            Console.WriteLine("{0}\t{1}\t\t{2}", n, nToBinary, resultToBinary);
            Console.WriteLine("result");
            Console.WriteLine(result);
        }
    }
}
