using System;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("RegularAccount:");
        var RegularAccount = new RegularAccount();

        RegularAccount.Deposit(1000);
        RegularAccount.Deposit(300);
        RegularAccount.Withdraw(800);
        RegularAccount.Withdraw(900);

        Console.WriteLine("\nFixedTermDepositAccount:");
        var FixedTermDepositAccount = new FixedTermDepositAccount();

        FixedTermDepositAccount.Deposit(2000);
        FixedTermDepositAccount.Withdraw(1500);
        
        Console.ReadKey();
    }

}