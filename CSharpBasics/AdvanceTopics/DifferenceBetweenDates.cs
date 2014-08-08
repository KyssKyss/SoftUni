using System;
using System.Globalization;

class Program
{
    //TODO: Ex.4 Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
    //Examples:
    static void Main()
    {
        string fDate = Console.ReadLine();
        string format = "dd.MM.yyyy";
        DateTime firstDate = DateTime.ParseExact(fDate, format, CultureInfo.InvariantCulture);
        string sDate = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(sDate, format, CultureInfo.InvariantCulture);
        string result = (secondDate - firstDate).TotalDays.ToString();
        Console.WriteLine(result);
    }
}
