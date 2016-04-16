/*Problem 2. Print Company Information• A company has name, address, phone number, fax number, web site and manager. 
The manager has first name, last name, age and a phone number.
• Write a program that reads the information about a company and its manager and prints it back on the console.
Print the information the same way as shown in the sample test. Make sure that you print "(no fax)" if an empty line is passed as fax number.

Example input:
program          user
Company name: Telerik Academy 
Company address: 31 Al. Malinov, Sofia 
Phone number: +359 888 55 55 555 
Fax number: 2 
Web site: http://telerikacademy.com/ 
Manager first name: Nikolay 
Manager last name: Kostov 
Manager age: 25 
Manager phone: +359 2 981 981   
 
Example output:
Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  
 */


using System;

class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        string managerFullName = managerFirstName + " " + managerLastName;

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", (faxNumber == string.Empty) ? "(no fax)" : faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", managerFullName, managerAge, managerPhone);
    }
}