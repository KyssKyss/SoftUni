using System;

namespace FourDigitNumberOperation
{
    class FourDigitNumberOperation
    {
        //TODO: Ex.6 Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        //•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        //•	Prints on the console the number in reversed order: dcba (in our example 1102).
        //•	Puts the last digit in the first position: dabc (in our example 1201).
        //•	Exchanges the second and the third digits: acbd (in our example 2101).
        //The number has always exactly 4 digits and cannot start with 0. Examples:
        //n	    sum of digits	reversed	last digit in front	second and third digits exchanged
        //2011	4	            1102	        1201	                    2101
        //3333	12	            3333	        3333	                    3333
        //9876	30	            6789	        6987	                    9786
        static void Main()
        {
            Console.WriteLine("Input four-digit number"); 
            int number = int.Parse(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
            int sum = a + b + c + d;
            int dcba = d * 1000 + c * 100 + b * 10 + a;
            int dabc = d * 1000 + a * 100 + b * 10 + c;
            int acbd = a * 1000 + c * 100 + b * 10 + d;
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", number, sum, dcba, dabc, acbd);
        }
    }
}
