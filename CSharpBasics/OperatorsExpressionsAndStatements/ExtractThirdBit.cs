using System;

namespace ExtractThirdBit
{
    class ExtractThirdBit
    {
        //TODO: Ex.11 Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
        //The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. Examples:
        //n     binary representation bit #3
        //5     00000000 00000101       0
        //0     00000000 00000000       0
        //15    00000000 00001111       1
        //5343  00010100 11011111       1
        //62241 11110011 00100001       0
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a number:");
                int n = int.Parse(Console.ReadLine());
                string nToBinary = Convert.ToString(n, 2).PadLeft(16, '0');
                const int position = 3;
                int mask = n >> position;
                int bit = mask & 1;
                Console.WriteLine(n + "\t" + nToBinary + "\t" + bit);
                Console.WriteLine(new string('-', Console.WindowWidth));
            }
        }
    }
}
