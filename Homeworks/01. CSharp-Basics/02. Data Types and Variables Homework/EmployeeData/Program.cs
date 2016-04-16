/*Problem 10. Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
• First name
• Last name
• Age (0...100)
• Gender (m or f)
• Personal ID number (e.g. 8306112507)
• Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 

 * Use descriptive names. Print the data at the console.*/

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string secondName = "Ivanov";
        byte age = 31;
        string gender = "Male";
        long personalId = 8306112507;
        int uniqueIdNumber = 27569999;

        Console.WriteLine("Emploee first name: {0}", firstName);
        Console.WriteLine("Emploee second name: {0}", secondName);
        Console.WriteLine("Emploee age: {0}", age);
        Console.WriteLine("Emploee gender: {0}", gender);
        Console.WriteLine("Emploee personal ID: {0}", personalId);
        Console.WriteLine("Emploee unique number: {0}", uniqueIdNumber);
    }
}