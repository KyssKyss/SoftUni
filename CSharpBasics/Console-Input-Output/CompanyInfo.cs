using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        //TODO: Ex.2 A company has name, address, phone number, fax number, web site and manager. The manager has first name,
        //last name, age and a phone number. Write a program that reads the information about a company and its manager 
        //and prints it back on the console.
        static void Main()
        {
            string companyName = "Software University";
            string companyAddress = "26 V.Kanchev, Sofia";
            string companyPhoneNumber = "+359 899 55 55 92";
            string faxNumber = null;
            string webSite = "http://softuni.bg";
            string managerFirstName = "Svetlin";
            string managerLastName = "Nakov";
            byte age = 25;
            string managerPhone = "+359 2 981 981";
            Console.WriteLine("{0}\r\nAdress: {1}\r\nTel. {2}",companyName, companyAddress, companyPhoneNumber);
            if (faxNumber == null)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}");
            }
            Console.WriteLine("Web site: {0}",webSite);
            Console.WriteLine("Manager: {0} {1} \r\n(age: {2}, tel. {3})", managerFirstName, managerLastName, age, managerPhone);
        }
    }
}
