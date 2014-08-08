using System;

namespace QuotesInString
{
    class QuotesInString
    {
        //TODO: Ex.8 Declare two string variables and assign them with following value:
        //The "use" of quotations causes difficulties.
        //Do the above in two different ways: with and without using quoted strings.
        //Print the variables to ensure that their value was correctly defined.
        static void Main()
        {
            string firstCase = "The \"use\" of quotations causes difficulties.";
            string secondCase = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(firstCase);
            Console.WriteLine(secondCase);
        }
    }
}
