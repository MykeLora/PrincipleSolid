using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;

public class EmployeeSalary
{
    public string? EmployeeName { get; set;}
    public double BasicSalary { get; set;}
    public double Bonus { get; set;}

    public double CalculateTotalSalary()
    {
        return BasicSalary + Bonus;
    }
}