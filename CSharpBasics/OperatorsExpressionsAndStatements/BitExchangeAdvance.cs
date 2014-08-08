using System;
namespace BitExchangeAdvance
{
    class BitExchangeAdvance
    {
        //TODO: Ex.16 Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
        //The first and the second sequence of bits may not overlap. Examples:
        //n	            p	q	k	binary representation of n	        binary result	                    result
        //1140867093	3	24	3	01000100 00000000 01000000 00010101	01000010 00000000 01000000 00100101	1107312677
        //4294901775	24	3	3	11111111 11111111 00000000 00001111	11111001 11111111 00000000 00111111	4194238527
        //2369124121	2	22	10	10001101 00110101 11110111 00011001	01110001 10110101 11111000 11010001	1907751121
        //987654321	    2	8	11	-	                                -	                                overlapping
        //123456789	    26	0	7	-	                                -	                                out of range
        //33333333333	-1	0	33	-	                                -	                                out of range
        static void Main()
        {
            Console.WriteLine("Write a number:");
            long n = long.Parse(Console.ReadLine());
            string nToBinary = Convert.ToString(n, 2).PadLeft(32, '0');
            Console.WriteLine("Write right position p:");
            int rightBitPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("Write left position q:");
            int leftBitPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("Write number sequence:");
            int k = int.Parse(Console.ReadLine());
            long result = n;
            bool isOverlap = false;
            for (int i = 0; i < k; i++)
            {
                if ((rightBitPosition != 0 && leftBitPosition != 0) && (rightBitPosition + k < 31) && (leftBitPosition + k < 31))
                {
                    if ((rightBitPosition + k < leftBitPosition) || (rightBitPosition + k > leftBitPosition + k))
                    {
                        long rightBit = (n >> rightBitPosition) & 1;
                        long leftBit = (n >> leftBitPosition) & 1;
                        result = result & (~(1 << leftBitPosition)) | (rightBit << leftBitPosition);
                        result = result & (~(1 << rightBitPosition)) | (leftBit << rightBitPosition);
                        leftBitPosition = leftBitPosition + 1;
                        rightBitPosition = rightBitPosition + 1;
                    }
                    else
                    {
                        isOverlap = true;
                    }
                }
                else
                {
                    Console.WriteLine("Out of range!");
                    break;
                }
            }
            if (isOverlap == false)
            {
                string resultToBinary = Convert.ToString(result, 2).PadLeft(32, '0');
                Console.WriteLine("n\t\tbinary representation - n\t\t\tbinary result");
                Console.WriteLine("{0}\t{1}\t\t{2}", n, nToBinary, resultToBinary);
                Console.WriteLine("result");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("OVELAPPING");
            }
        }
    }
}
