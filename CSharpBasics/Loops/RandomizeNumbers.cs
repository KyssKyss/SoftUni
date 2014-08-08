using System;

namespace RandomiseNumbers
{
    class RandomizeNumbers
    {
        //TODO: Ex.12 Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. Examples:
        //n	    randomized numbers 1…n
        //3	    2 1 3
        //10	3 4 8 2 6 7 9 1 10 5 
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter the the numbers of integers:");
                string nReader = Console.ReadLine();
                int n = 0;                
                Random rnd = new Random();
                int index = 0;
                int temp = 0;
                if (int.TryParse(nReader, out n))
                {
                    int[] arr = new int[n];
                    //Populate the array
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = i + 1;
                    }
                    // Randomize array
                    for (int i = 0; i < arr.Length; i++)
                    {
                        index = rnd.Next(arr.Length);
                        temp = arr[i];
                        arr[i] = arr[index];
                        arr[index] = temp;
                    }
                    //Read the array
                    foreach (var item in arr)
                    {
                        Console.Write("{0} ", item);
                    }
                    Console.WriteLine();    
                }                       
            }           
        }
    }
}
