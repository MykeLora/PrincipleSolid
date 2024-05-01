internal class Program
{
   
    private static void Main(string[] args)
    {
        EmployeeSalary maycolSalary = new EmployeeSalary
        {
            EmployeeName = "Maycol",
            BasicSalary = 25500,
            Bonus = 1000
        };

        double totalSalary = maycolSalary.CalculateTotalSalary();

        SalaryDatabaseHandler dbHandler = new SalaryDatabaseHandler();
            dbHandler.SaveSalaryDetails(maycolSalary, totalSalary);
        Console.ReadKey();
    }
} 