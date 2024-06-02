using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var fullTime = new FullTimeEmployee { HourlyRate = 25 };
        var salaryCalculator = new SalaryCalculator();

        Console.WriteLine($"Full-Time Employee Salary: ${salaryCalculator.CalculateSalary(fullTime)}");
        var intern = new Intern { HourlyRate = 20, HoursWorked = 80 };
        
        Console.WriteLine($"Intern Salary: ${salaryCalculator.CalculateSalary(intern)}");

        Console.ReadKey();
    }
}