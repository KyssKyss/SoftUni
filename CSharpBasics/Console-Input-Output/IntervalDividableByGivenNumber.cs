using System;

namespace IntervalDividableByGivenNumber
{
    class IntervalDividableByGivenNumber
    {
        //TODO: Ex.11 Write a program that reads two positive integer numbers and prints how many numbers p 
        //exist between them such that the reminder of the division by 5 is 0. Examples:
        //start	end	p	comments
        //17	25	2	20, 25
        //5	    30	6	5, 10, 15, 20, 25, 30
        //3	    33	6	5, 10, 15, 20, 25, 30
        //3	    4	0	-
        //99	120	5	100, 105, 110, 115, 120
        //107	196	18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter start number:");
                string startNumberReader = Console.ReadLine();
                int startNumber = 0;
                Console.WriteLine("Please enter end number:");
                string endNumberReader = Console.ReadLine();
                int endNumber = 0;
                int numberP = 0;
                string comments = null;
                if (int.TryParse(startNumberReader, out startNumber) && int.TryParse(endNumberReader, out endNumber))
                {
                    for (int i = startNumber; i <= endNumber; i++)
                    {
                        if (i % 5 == 0)
                        {
                            numberP++;
                            comments += i.ToString() + ' ';
                        }
                    }
                    Console.WriteLine("There {0} number/s between {1} and {2}: {3}", numberP, startNumber, endNumber, comments);
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }
                Console.WriteLine(new string('-',Console.WindowWidth));
            }            
        }
    }
}
