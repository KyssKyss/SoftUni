using System;

namespace DecimalToHex
{
    class DecimalToHex
    {
        //TODO: Ex.16 Using loops write a program that converts an integer number to its hexadecimal representation. 
        //The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 
        //Examples:
        //decimal	        hexadecimal
        //254	            FE
        //6883	            1AE3
        //338583669684	    4ED528CBB4
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter a number:");
                long decimalNumber = long.Parse(Console.ReadLine());
                string str = null;                
                while (decimalNumber > 0)
                {
                    long reminder = decimalNumber % 16;
                    switch (reminder)
                    {
                        case 0:
                            str += "0";
                            break;
                        case 1:
                            str += "1";
                            break;
                        case 2:
                            str += "2";
                            break;
                        case 3:
                            str += "3";
                            break;
                        case 4:
                            str += "4";
                            break;
                        case 5:
                            str += "5";
                            break;
                        case 6:
                            str += "6";
                            break;
                        case 7:
                            str += "7";
                            break;
                        case 8:
                            str += "8";
                            break;
                        case 9:
                            str += "9";
                            break;
                        case 10:
                            str += "A";
                            break;
                        case 11:
                            str += "B";
                            break;
                        case 12:
                            str += "C";
                            break;
                        case 13:
                            str += "D";
                            break;
                        case 14:
                            str += "E";
                            break;
                        case 15:
                            str += "F";
                            break;
                        default:
                            break;
                    }
                    decimalNumber /= 16;
                }               
                char[] result = str.ToCharArray(); 
                Array.Reverse(result);
                Console.WriteLine(result);
                Console.WriteLine(new string('-', Console.WindowWidth)); //separate results by dashes
            }            
        }
    }
}
