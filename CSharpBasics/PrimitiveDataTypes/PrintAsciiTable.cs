using System;
using System.Text;
namespace PrintASCIITable
{
    class PrintASCIITable
    {
        //TODO: Ex.14 Write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255).
        //Note that some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; //Encode the chars so Cyrillic symbols can be visible
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine("{0} = {1}", i, (char)i);
            }            
        }
    }
}
