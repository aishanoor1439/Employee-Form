using System;

namespace Employee_Form
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            string name, fatherName, phoneNo, designation, dateOfHiring;
            double salary;

            // Input data
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Father Name:");
            fatherName = Console.ReadLine();
            Console.WriteLine("Phone No:");
            phoneNo = Console.ReadLine();
            Console.WriteLine("Designation:");
            designation = Console.ReadLine();
            Console.WriteLine("Date of Hiring:");
            dateOfHiring = Console.ReadLine();
            Console.WriteLine("Salary:");
            salary = Convert.ToDouble(Console.ReadLine());

            // Form display
            Console.WriteLine("|-----------------------------------------------------------------------");
            Console.WriteLine("|\t\tABC COMPANY\n|\t\tEmployee Form                                                                   ");
            Console.WriteLine("|\t\tName: {0}\n|\t\tFather Name: {1}\n|\t\tPhone No: {2}\n|\t\tDesignation: {3}\n|\t\tDate of Hiring: {4}\n|\t\tSalary: ${5:F3} ",
                name, fatherName, phoneNo, designation, dateOfHiring, salary);
            Console.WriteLine("|-----------------------------------------------------------------------");

        }
    }
}
