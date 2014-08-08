using System;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        //TODO: Ex.10 You are given n integers (given in a single line, separated by a space). Write a program that checks 
        //whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n,
        //so the first element is odd, the second is even, etc. Examples:
        //numbers	        result
        //2 1 1 6 3	        yes
        //                product = 6
        //3 10 4 6 5 1	    yes
        //                product = 60
        //4 3 2 5 2	        no
        //                odd_product = 16
        //                even_product = 15
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter a sequence on 'n' numbers");
                string[] numberSequence = Console.ReadLine().Split(' ');
                int oddSum = 1;
                int evenSum = 1;
                bool isProductEqual = false;
                for (int i = 0; i < numberSequence.Length; i++)
                {
                    int number = int.Parse(numberSequence[i]);
                    if (i % 2 == 1)
                    {
                        evenSum *= number;
                    }
                    else
                    {
                        oddSum *= number;
                    }
                }
                if (oddSum == evenSum)
                {
                    isProductEqual = true;
                }
                if (isProductEqual)
                {
                    Console.WriteLine("{0}\r\nproduct = {1}", isProductEqual, oddSum);
                }
                else
                {
                    Console.WriteLine("{0}\r\noddProduct = {1}\r\nevenProduct = {2}", isProductEqual, oddSum, evenSum);
                }
            }            
        }
    }
}
