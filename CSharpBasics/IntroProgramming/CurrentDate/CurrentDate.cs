using System;

namespace CurrentDate
{
    class CurrentDate
    {
        static void Main()
        {
            //Create a console application that prints the current date and time. Find in Internet how.
            Console.WriteLine(DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()); //Use DateTime structure
        }
    }
}
