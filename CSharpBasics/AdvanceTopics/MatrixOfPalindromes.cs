using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    class MatrixOfPalindromes
    {
        //TODO: Ex.7 Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
        //Input           Output
        //3 6             aaa aba aca ada aea afa
        //                bbb bcb bdb beb bfb bgb
        //                ccc cec cdc cfc cgc chc
        static void Main()
        {
            string number = Console.ReadLine();
            int n = int.Parse(number[0].ToString());
            int m = int.Parse(number[2].ToString());
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "a");
            dictionary.Add(1, "b");
            dictionary.Add(2, "c");
            dictionary.Add(3, "d");
            dictionary.Add(4, "e");
            dictionary.Add(5, "f");
            dictionary.Add(6, "g");
            dictionary.Add(7, "h");
            dictionary.Add(8, "i");
            dictionary.Add(9, "j");
            for (int k = 0; k < n; k++)
            {
                for (int i = k; i < m + k; i++)
                {
                    Console.Write("{0}{1}{2} ", dictionary[k], dictionary[i], dictionary[k]);
                }
                Console.WriteLine();
            }
        }
    }
}
