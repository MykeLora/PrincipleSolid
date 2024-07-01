using System;
public class Program
{
    public static void DisplayBonus(IBonusProvider bonusProvider)
    {
        Console.WriteLine($"Bonus: {bonusProvider.CalculateBonus()}");
    }

    public static void Main(string[] args)
    {
        
       Employees emp = new Employees{Salary = 5000};
       DisplayBonus(emp);

        Console.ReadKey();
    }

}