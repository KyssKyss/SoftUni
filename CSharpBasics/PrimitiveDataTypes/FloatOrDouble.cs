using System;

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        //TODO: Ex.2 Which of the following values can be assigned to a variable of type float
        //and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
        //Write a program to assign the numbers in variables and print them to ensure no precision is lost.
        static void Main()
        {
            double doubleNumber = 34.567839023;
            Console.WriteLine("Doubles: {0}",doubleNumber);
            doubleNumber = 8923.1234857;
            Console.WriteLine("Doubles: {0}", doubleNumber);
            float floatNumber = 12.345f;
            Console.WriteLine("Floats: {0}", floatNumber);
            floatNumber = 3456.091f;
            Console.WriteLine("Floats: {0}", floatNumber);
        }
    }
}
