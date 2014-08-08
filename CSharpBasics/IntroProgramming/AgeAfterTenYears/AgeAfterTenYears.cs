using System;

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            //Write a program to read your age from the console and print how old you will be after 10 years.
            Console.WriteLine("Enter your current age:");
            int age = int.Parse(Console.ReadLine()); // Read from the console
            int ageAfter = age + 10;
            Console.WriteLine("After 10 years you will be in " + ageAfter);
        }
    }
}
