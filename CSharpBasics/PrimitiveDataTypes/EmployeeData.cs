using System;

namespace EmployeeData
{
    class EmployeeData
    {
        //TODO: Ex.11 A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        //•	First name
        //•	Last name
        //•	Age (0...100)
        //•	Gender (m or f)
        //•	Personal ID number (e.g. 8306112507)
        //•	Unique employee number (27560000…27569999)
        //Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
        //Use descriptive names. Print the data at the console.
        static void Main()
        {
            //Add variables
            string firstName;
            string lastName;
            byte age;
            char gender;
            long personalID;
            uint employeeNumber;
            //Declare infortmation about single employee
            firstName = "Ivan";
            lastName = "Ivanov";
            age = 99;
            gender = 'M';
            personalID = 8306112509;
            employeeNumber = 27563267;
            //Print the data
            Console.WriteLine("Employee {0} {1}, {2} years old, with personal ID number: {3}, and employee number: {4}, of {5} gender.",
            firstName, lastName, age, personalID, employeeNumber, gender);
        }
    }
}
