using System;
namespace PrintCopyRightTriangle
{
    class PrintCopyRightTriangle
    {
        //TODO: Ex.9 Write a program that prints an isosceles triangle of 9 copyright symbols '©'
        static void Main(string[] args)
        {
            char copyright = '\u00A9';
            Console.WriteLine(new String(' ',3) + copyright); //Add 3 times space after with @
            Console.WriteLine(new String(' ', 2) + copyright + " " + copyright);
            Console.WriteLine(" " + copyright + "   " + copyright);
            Console.WriteLine("{0} {0} {0} {0}", copyright);
        }
    }
}
