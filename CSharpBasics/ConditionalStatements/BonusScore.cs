using System;

namespace BonusScore
{
    class BonusScore
    {
        //TODO: Ex.2 Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        //•	If the score is between 1 and 3, the program multiplies it by 10.
        //•	If the score is between 4 and 6, the program multiplies it by 100.
        //•	If the score is between 7 and 9, the program multiplies it by 1000.
        //•	If the score is 0 or more than 9, the program prints “invalid score”.
        //Examples
        //score     result
        //2	        20
        //4	        400
        //9	        9000
        //-1	    invalid score
        //10	    invalid score
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please write a score:");
                string scoreReader = Console.ReadLine();
                int score = 0;
                int result = 0;
                if (int.TryParse(scoreReader, out score) && score >= 0)
                {
                    if (score >= 1 && score <= 3)
                    {
                        result = score * 10;
                    }
                    else if (score >= 4 && score <= 6)
                    {
                        result = score * 100;
                    }
                    else if (score >= 7 && score <= 9)
                    {
                        result = score * 1000;
                    }
                    else if (score == 0 || score > 9)
                    {
                        Console.WriteLine("Invalid score");
                        break;
                    }
                    Console.WriteLine("The result is: {0}",result);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter number between 1-9");
                }
            }            
        }
    }
}
