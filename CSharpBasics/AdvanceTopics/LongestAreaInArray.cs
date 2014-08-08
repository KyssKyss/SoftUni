using System;

class Program
{
    //TODO: Ex.6 Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and 
    //n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then
    //its elements). If multiple sequences have the same maximal length, print the leftmost of them. Examples:
    //  Input                              Output
    //  6                                   3
    //  hi                                  ok
    //  hi                                  ok
    //  hello                               ok
    //  ok
    //  ok
    //  ok
    static void Main()
    {
        Console.WriteLine("Write the number 'n': ");
        int n = int.Parse(Console.ReadLine());
        string[] strArray = new string[n];       
        int maxCounter = 0;
        string temp = null;
        for (int i = 0; i < n; i++)
        {
            strArray[i] = Console.ReadLine();
        }
        Array.Sort(strArray);
        for (int i = 0; i < strArray.Length; i++)
        {
            int counter = 0;
            for (int j = i; j < strArray.Length; j++)
            {
                if ((strArray[i]) == strArray[j])
                {
                    counter++;
                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                        temp = strArray[i];
                    }
                }
            }            
        }
        Console.WriteLine(maxCounter);
        for (int i = 0; i < maxCounter; i++)
        {
            Console.WriteLine(temp);
        }        
    }
}
