using System;

namespace BeerTime
{
    class BeerTime
    {
        //TODO: Ex.10 A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
        //(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” 
        //according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times. 
        //Examples:
        //time	        result
        //1:00 PM	    beer time
        //4:30 PM	    beer time
        //10:57 PM	    beer time
        //8:30 AM	    non-beer time
        //02:59 AM	    beer time
        //03:00 AM	    non-beer time
        //03:26 AM	    non-beer time
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a time in format hh:mm tt");
                DateTime time = new DateTime();
                DateTime morningTime = DateTime.Parse("03:00 AM");
                DateTime eveningTime = DateTime.Parse("01:00 PM");
                if (DateTime.TryParse(Console.ReadLine(), out time))
                {
                    if (time >= morningTime && time <= eveningTime)
                    {
                        Console.WriteLine("non-beer time");
                    }
                    else
                    {
                        Console.WriteLine("beer time");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid time");
                }
                Console.WriteLine(new string('-', Console.WindowWidth));
            }            
        }
    }
}
