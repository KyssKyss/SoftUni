using System;

namespace DebugingPlay
{
    class PrintSequence
    {
        static void Main()
        {
            //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
            for (int i = 2; i < 12; i++) //Loop 10 times for all 10 members of the sequence
            {
                if (i % 2 == 0) // check if the number is even
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }                
            }
        }
    }
}
