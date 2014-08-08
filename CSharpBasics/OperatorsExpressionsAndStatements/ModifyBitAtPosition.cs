using System;

namespace ModifyBitAtPosition
{
    class ModifyBitAtPosition
    {
        //TODO: Ex.14 We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code)
        //that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. Examples:
        //n	    binary representation of n	p	v	binary result	    result
        //5	    00000000 00000101	        2	0	00000000 00000001	1
        //0	    00000000 00000000	        9	1	00000010 00000000	512
        //15	00000000 00001111	        1	1	00000000 00001111	15
        //5343	00010100 11011111	        7	0	00010100 01011111	5215
        //62241	11110011 00100001	        11	0	11110011 00100001	62241
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a number:");
                int n = int.Parse(Console.ReadLine());
                string nToBinary = Convert.ToString(n, 2).PadLeft(16, '0');
                Console.WriteLine("Write a position:");
                int position = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a value of v:");
                int value = int.Parse(Console.ReadLine());
                int mask = 0;
                int bit = 0;
                //Make a bit check of 'value'
                if (value == 0)
                {
                    mask = ~(1 << position);
                    bit = n & mask; 
                }
                else
                {
                    mask = 1 << position;
                    bit = n | mask;
                }
                string bitToBinary = Convert.ToString(bit, 2).PadLeft(16, '0');
                Console.WriteLine("n\tbinary representation of n\tp\tv\tbinary result\t\tresult");
                Console.WriteLine(n + "\t" + nToBinary + "\t\t" + position + "\t" + value + "\t" + bitToBinary + "\t" + bit);
                Console.WriteLine(new string('-', Console.WindowWidth));
            }
        }
    }
}
