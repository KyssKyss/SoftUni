using System;

namespace HexToDecimal
{
    class HexToDecimal
    {
        //TODO: Ex.15 Using loops write a program that converts a hexadecimal integer number to its decimal form. 
        //The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 
        //Examples:
        //hexadecimal	    decimal
        //FE	            254
        //1AE3	            6883
        //4ED528CBB4	    338583669684
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write a number in hexadecimal format:");
                string hex = Console.ReadLine();
                long result = 0;
                for (int i = 0; i < hex.Length; i++)
                {
                    switch (hex[(hex.Length - 1) - i])
                    {
                        case '0':
                            result += 0 * (long)Math.Pow(16, i);
                            break;
                        case '1':
                            result += 1 * (long)Math.Pow(16, i);
                            break;
                        case '2':
                            result += 2 * (long)Math.Pow(16, i);
                            break;
                        case '3':
                            result += 3 * (long)Math.Pow(16, i);
                            break;
                        case '4':
                            result += 4 * (long)Math.Pow(16, i);
                            break;
                        case '5':
                            result += 5 * (long)Math.Pow(16, i);
                            break;
                        case '6':
                            result += 6 * (long)Math.Pow(16, i);
                            break;
                        case '7':
                            result += 7 * (long)Math.Pow(16, i);
                            break;
                        case '8':
                            result += 8 * (long)Math.Pow(16, i);
                            break;
                        case '9':
                            result += 9 * (long)Math.Pow(16, i);
                            break;
                        case 'A':
                            result += 10 * (long)Math.Pow(16, i);
                            break;
                        case 'B':
                            result += 11 * (long)Math.Pow(16, i);
                            break;
                        case 'C':
                            result += 12 * (long)Math.Pow(16, i);
                            break;
                        case 'D':
                            result += 13 * (long)Math.Pow(16, i);
                            break;
                        case 'E':
                            result += 14 * (long)Math.Pow(16, i);
                            break;
                        case 'F':
                            result += 15 * (long)Math.Pow(16, i);
                            break;
                        default:
                            result += 16 * (long)Math.Pow(16, i);
                            break;
                    }
                }
                Console.WriteLine("{0} in decimal: {1}",hex, result);
                Console.WriteLine(new string('-', Console.WindowWidth));
            }            
        }
    }
}
