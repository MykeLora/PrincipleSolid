using System;
internal class Program
{
    public static void Main(string[] args)
    {
        BankAccounts savingsAccount = new SavingsAccount("SA1243", 1000m, 0.03m);
        BankAccounts currentAccount = new CurrentAccount("CA564", 1300m, 700m);

        Console.WriteLine("Before Transactions: ");
        PrintAccountDetails(savingsAccount);
        PrintAccountDetails(currentAccount);

        savingsAccount.Withdraw(800m);
        currentAccount.Withdraw(2500m);

        Console.WriteLine("\nAfter Transactions: ");
        PrintAccountDetails(savingsAccount);
        PrintAccountDetails(currentAccount);

        Console.ReadKey();
    }

    static void PrintAccountDetails(BankAccounts account)
    {
        Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
    }
}