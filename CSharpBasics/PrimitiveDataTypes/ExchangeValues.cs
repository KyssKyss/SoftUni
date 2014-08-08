using System;

namespace ExchangeValues
{
    class ExchangeValues
    {
        //TODO: Ex.10 Declare two integer variables a and b and assign them with 5 and 10
        // and after that exchange their values. Print the variable values before and after the exchange.
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before exchange:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            b = b - a;
            a = a + b;
            Console.WriteLine("After the exchange:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
        }
    }
}
