using System;

namespace OddOrEven
{
    class OddOrEven
    {
        //TODO: Ex.1 Write an expression that checks if given integer is odd or even. Examples:
        //n	Odd?
        //3	true
        //2	false
        //-2	false
        //-1	true
        //0	false
        static void Main()
        {
            //number = 3
            int number = 3;
            bool isOdd = false;
            if (((number % 2) == 1) || ((number % 2) == -1)) //check if the number has a remainder of 1 or -1
            {
                isOdd = true;
            }
            Console.WriteLine(isOdd);
            //number = 2
            number = 2;
            isOdd = false;
            if (((number % 2) == 1) || ((number % 2) == -1))
            {
                isOdd = true;
            }
            Console.WriteLine(isOdd);
            //number = -2
            number = -2;
            isOdd = false;
            if (((number % 2) == 1) || ((number % 2) == -1))
            {
                isOdd = true;
            }
            Console.WriteLine(isOdd);
            //number = -1
            number = -1;
            isOdd = false;
            if (((number % 2) == 1) || ((number % 2) == -1))
            {
                isOdd = true;
            }
            Console.WriteLine(isOdd);
            //number = 0
            number = 0;
            isOdd = false;
            if (((number % 2) == 1) || ((number % 2) == -1))
            {
                isOdd = true;
            }
            Console.WriteLine(isOdd);
        }
    }
}
