using System;

namespace IsThirdNumberSeven
{
    class IsThirdNumberSeven
    {
        //TODO: Ex.5 Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:
        //n	Third digit 7?
        //5	        false
        //701	    true
        //9703	    true
        //877	    false
        //777877	false
        //9999799	true
        static void Main()
        {
            int number = 0;
            int digit = 7;
            bool isThirdNumSeven = false;
            //number = 5
            number = 5;
            number /= 100;
            if (number > 10)
            {
                number %= 10;
            }
            if (number == digit)
            {
                isThirdNumSeven = true;
            }
            Console.WriteLine(isThirdNumSeven);
            isThirdNumSeven = false;
            //number = 701
            number = 701;
            number /= 100;
            if (number > 10)
            {
                number %= 10;
            }
            if (number == digit)
            {
                isThirdNumSeven = true;
            }
            Console.WriteLine(isThirdNumSeven);
            isThirdNumSeven = false;
            //number = 9703
            number = 9703;
            number /= 100;
            if (number > 10)
            {
                number %= 10;
            }
            if (number == digit)
            {
                isThirdNumSeven = true;
            }
            Console.WriteLine(isThirdNumSeven);
            isThirdNumSeven = false;
            //number = 877
            number = 877;
            number /= 100;
            if (number > 10)
            {
                number %= 10;
            }
            if (number == digit)
            {
                isThirdNumSeven = true;
            }
            Console.WriteLine(isThirdNumSeven);
            isThirdNumSeven = false;
            //number = 777877
            number = 777877;
            number /= 100;
            if (number > 10)
            {
                number %= 10;
            }
            if (number == digit)
            {
                isThirdNumSeven = true;
            }
            Console.WriteLine(isThirdNumSeven);
            isThirdNumSeven = false;
            //number = 9999799
            number = 9999799;
            number /= 100;
            if (number > 10)
            {
                number %= 10;
            }
            if (number == digit)
            {
                isThirdNumSeven = true;
            }
            Console.WriteLine(isThirdNumSeven);
        }
    }
}
