//This program was written by Sydnni Ahlheim on 11/03/18
//This programs purpose is to test out the Employee class I made and to write out the captured employee info to a text file. 
using System;
using System.IO;
namespace EmployeeDemo
{
    class EmployeeDemo
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            string dataString;
            double paycheck;

            do
            {
                Console.WriteLine("Please enter the employee number.");
                newEmployee.EmployeeId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the employee name.");
                newEmployee.EmployeeName = Console.ReadLine();

                Console.WriteLine("Please enter the employee's salary");
                newEmployee.Salary = Convert.ToDouble(Console.ReadLine());

                dataString = newEmployee.ToString();
                Console.WriteLine(dataString);
                paycheck = newEmployee.CalculatePaycheck(newEmployee.Salary);
                Console.WriteLine("This employee's paycheck is " + paycheck.ToString("C"));

                StreamWriter empRecordFile = new StreamWriter(DateTime.Now.ToString("yyyyMMdd") + "Employee_Records.txt", true);
                empRecordFile.WriteLine(dataString);
                empRecordFile.WriteLine("This employee's paycheck is " + paycheck.ToString("C"));
                empRecordFile.Close();

                Console.WriteLine("Do you want to continue? Y/N");
            }

            while (Console.ReadLine() == "Y" || Console.ReadLine() == "y");

            string dirPath = Directory.GetCurrentDirectory();
            Console.WriteLine("The information you have provided has been saved to a file with the location: " + dirPath);
            Console.ReadLine();
        }
    }
}
