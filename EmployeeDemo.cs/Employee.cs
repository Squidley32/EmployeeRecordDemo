//This program was written by Sydnni Ahlheim on 11/03/18
//This programs purpose is to create an Employee class that can be used as an employee records program
using System;

class Employee
{
    public int EmployeeId
    { get; set; }
    public string EmployeeName
    { get; set; }
    public double Salary
    { get; set; }

    public double CalculatePaycheck(double salary)
    {
        double pay = salary / 26;
        return pay;

    }

    public override string ToString()
    {   
        return "Employee Information: 1. ID number - " + EmployeeId + "- 2. Name - " + EmployeeName + "-" + " 3. Salary - " + Salary.ToString("C");
    }

}

