using System;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        //TODO: Ex.12 Write an expression that extracts from given integer n the value of given bit at index p. Examples:
        //n     binary representation p bit @ p
        //5     00000000 00000101     2     1
        //0     00000000 00000000     9     0
        //15    00000000 00001111     1     1
        //5343  00010100 11011111     7     1
        //62241 11110011 00100001     11    0
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a number:");
                int n = int.Parse(Console.ReadLine());
                string nToBinary = Convert.ToString(n, 2).PadLeft(16, '0');
                Console.WriteLine("Write a search position:");
                int position = int.Parse(Console.ReadLine());
                int mask = n >> position;
                int bit = mask & 1;
                Console.WriteLine(n + "\t" + nToBinary + "\t" + bit);
                Console.WriteLine(new string('-', Console.WindowWidth));
            }
        }
    }
}
using System;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        //TODO: Ex.12 Write an expression that extracts from given integer n the value of given bit at index p. Examples:
        //n     binary representation p bit @ p
        //5     00000000 00000101     2     1
        //0     00000000 00000000     9     0
        //15    00000000 00001111     1     1
        //5343  00010100 11011111     7     1
        //62241 11110011 00100001     11    0
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a number:");
                int n = int.Parse(Console.ReadLine());
                string nToBinary = Convert.ToString(n, 2).PadLeft(16, '0');
                Console.WriteLine("Write a search position:");
                int position = int.Parse(Console.ReadLine());
                int mask = n >> position;
                int bit = mask & 1;
                Console.WriteLine(n + "\t" + nToBinary + "\t" + bit);
                Console.WriteLine(new string('-', Console.WindowWidth));
            }
        }
    }
}
