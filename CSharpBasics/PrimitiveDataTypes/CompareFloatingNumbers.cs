using System;

namespace CompareFloatingNumbers
{
    class CompareFloatingNumbers
    {
        //TODO: Ex.3 Write a program that safely compares floating-point numbers with precision eps = 0.000001.
        //Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic.
        //Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps
        //Example:
        //5.3	6.01	            false	The difference of 0.71 is too big (> eps)
        //5.00000001	5.00000003	true	The difference 0.00000002 < eps
        //-0.0000007	0.00000007	true	The difference 0.00000077 < eps
        //-4.999999	-4.999998	    false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
        static void Main()
        {
            double eps = 0.000001;
            //1
            double a = 5.3;
            double b = 6.01;
            bool comparer = ((b - a) < eps);
            Console.WriteLine(comparer + " The difference of 0.71 is too big.");
            //2
            a = 5.00000001;
            b = 5.00000003;
            comparer = ((b - a) < eps);
            Console.WriteLine(comparer + " The difference 0.00000002 < eps.");
            //3
            a = -0.0000007;
            b = 0.00000007;
            comparer = ((b - a) < eps);
            Console.WriteLine(comparer + " The difference 0.00000077 < eps.");
            //4
            a = -4.999999;
            b = -4.999998;
            comparer = ((b - a) < eps);
            Console.WriteLine(comparer + " Border case. The difference 0.000001 == eps. We consider the numbers are different.");
        }
    }
}
