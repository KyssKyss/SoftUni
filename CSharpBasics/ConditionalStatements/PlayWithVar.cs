using System;

namespace PlayWithVar
{
    class PlayWithVar
    {
        //TODO: Ex.9 Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
        //If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. 
        //Print the result at the console. Use switch statement. Example:
        //program	                    user
        //Please choose a type:
        //1 --> int
        //2 --> double
        //3 --> string	                3
        //Please enter a string:	    hello
        //hello*
        // --Or--
        //program	                    user
        //Please choose a type:
        //1 --> int
        //2 --> double
        //3 --> string	                2
        //Please enter a double:        1.5
        //2.5	
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please choose a type:");
                Console.WriteLine("1 --> int");
                Console.WriteLine("2 --> double");
                Console.Write("3 --> string\t");
                string optionReader = Console.ReadLine();
                int option = 0;
                double result = 0;
                string inputReader = null;
                if (int.TryParse(optionReader, out option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.Write("Please enter a int:\t");
                            inputReader = Console.ReadLine();
                            double input = 0;
                            if (double.TryParse(inputReader, out input))
                            {
                                result = input + 1;
                                Console.WriteLine(result);
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input!");
                            }
                            break;
                        case 2:
                            Console.Write("Please enter a double:\t");
                            inputReader = Console.ReadLine();
                            if (double.TryParse(inputReader, out input))
                            {
                                result = input + 1;
                                Console.WriteLine(result);
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input!");
                            }
                            break;
                        case 3:
                            Console.Write("Please enter a string:\t");
                            inputReader = Console.ReadLine();
                            Console.WriteLine(inputReader + "*");
                            break;
                        default:
                            Console.WriteLine("Choose between 1 - 3");
                            break;
                    }
                }
            }
        }
    }
}
