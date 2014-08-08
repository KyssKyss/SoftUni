using System;

namespace DivideBy5and7
{
    class DivideBy5and7
    {
        //TODO: Ex.3 Write a Boolean expression that checks for given integer if it can be divided (without remainder)
        //by 7 and 5 in the same time. Examples:
        //n	Divided by 7 and 5?
        //3	false
        //0	false
        //5	false
        //7	false
        //35	true
        //140	true
        static void Main()
        {
            int number;
            bool isDivide = false;
            //number = 3
            number = 3;
            if ((number % 5 == 0) && (number % 7 == 0) && (number != 0))
            {
                isDivide = true;
            }
            Console.WriteLine(isDivide);
            //number = 0
            number = 0;
            if ((number % 5 == 0) && (number % 7 == 0) && (number != 0))
            {
                isDivide = true;
            }
            Console.WriteLine(isDivide);
            //number = 5
            number = 5;
            if ((number % 5 == 0) && (number % 7 == 0) && (number != 0))
            {
                isDivide = true;
            }
            Console.WriteLine(isDivide);
            //number = 7
            number = 7;
            if ((number % 5 == 0) && (number % 7 == 0) && (number != 0))
            {
                isDivide = true;
            }
            Console.WriteLine(isDivide);
            //number = 35
            number = 35;
            if ((number % 5 == 0) && (number % 7 == 0) && (number != 0))
            {
                isDivide = true;
            }
            Console.WriteLine(isDivide);
            //number = 140
            number = 140;
            if ((number % 5 == 0) && (number % 7 == 0) && (number != 0))
            {
                isDivide = true;
            }
            Console.WriteLine(isDivide);
        }
    }
}
