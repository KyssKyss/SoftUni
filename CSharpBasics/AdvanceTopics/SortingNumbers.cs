using System;

class Program
{
    //TODO: Ex.5 Write a program that reads a number n and a sequence of n integers, sorts them and prints them. Examples:
    //Input                  Output
    //5                       -3
    //3                       0
    //-3                      2
    //2                       3
    //122                     122
    //0
    static void Main()
    {
        Console.WriteLine("Write a the 'n' number:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
