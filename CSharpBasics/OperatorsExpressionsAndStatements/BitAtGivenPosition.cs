using System;

namespace BitAtGivenPosition
{
    class BitAtGivenPosition
    {
        //TODO: Ex.13 Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given 
        //integer number n has value of 1. Examples:
        //n       binary representation of n p bit @ p == 1
        //5       00000000 00000101          2    true
        //0       00000000 00000000          9    false
        //15      00000000 00001111          1    true
        //5343    00010100 11011111          7    true
        //62241   11110011 00100001          11   false
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a number:");
                int n = int.Parse(Console.ReadLine());
                string nToBinary = Convert.ToString(n, 2).PadLeft(16, '0');
                Console.WriteLine("Write a search position:");
                int position = int.Parse(Console.ReadLine());
                bool isOne = false;
                int mask = n >> position;
                int bit = mask & 1;                
                if (bit == 1)
                {
                    isOne = true;
                }
                Console.WriteLine(n + "\t" + nToBinary + "\t" + isOne);
                Console.WriteLine(new string('-', Console.WindowWidth));
            }
        }
    }
}
