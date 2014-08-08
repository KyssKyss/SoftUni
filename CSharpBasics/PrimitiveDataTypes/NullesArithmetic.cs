using System;

namespace NullsArithmetic
{
    class NullsArithmetic
    {
        //TODO: Ex.13 Create a program that assigns null values to an integer and to a double variable.
        //Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.
        static void Main()
        {
            //int intVariable; //Error the variable have to be sign with some value, even if that's "null".
            int? intVariable = 4;
            //double doubleVar = null; //Error not nullable!
            //The right way is by adding "?" after the type
            double? doubleVar = null;
            Console.WriteLine(intVariable + " " + doubleVar);
        }
    }
}
