using System;

namespace MinMaxSumAndAverageOfNumbers
{
    class MinMaxSumAndAverageOfNumbers
    {
        //TODO: Ex.3 Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
        //the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
        //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
        //The output is like in the examples below. Examples:
        //input	    output		
        //3       min = 1
        //2       max = 5
        //5       sum = 8
        //1	      avg = 2.67
        //Or
        //input	    output
        //2       min = -1
        //-1      max = 4
        //4	      sum = 3
        //        avg = 1.50
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write the size of the integer sequence:");
                string sequenceReader = Console.ReadLine();
                int sequenceSize = 0;
                int sum = 0;
                int min = int.MaxValue;
                int max = int.MinValue;
                float average = 0;
                if (int.TryParse(sequenceReader, out sequenceSize))
                {
                    for (int i = 0; i < sequenceSize; i++)
                    {
                        int number = int.Parse(Console.ReadLine());
                        if (number <= min)
                        {
                            min = number;
                        }
                        if (number >= max)
                        {
                            max = number;
                        }
                        sum += number;
                    }
                    average = (float) sum / (float) sequenceSize;
                    Console.WriteLine("The minimum number is: {0}", min);
                    Console.WriteLine("The maximum number is: {0}", max);
                    Console.WriteLine("The sum of all {0} numbers is: {1}", sequenceSize, sum);
                    Console.WriteLine("And the average is {0:F2}", average);
                }             
            }            
        }
    }
}
