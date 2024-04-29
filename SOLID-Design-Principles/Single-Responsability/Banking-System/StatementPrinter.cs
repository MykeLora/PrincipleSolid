public class StatementPrinter
{
    public void Print(BankAccount bankAccount)
    {
        Console.WriteLine($"Statement for Account: {bankAccount.AccountNumber}");
        Console.WriteLine("-----------------------------");
        
        foreach (var transaction in bankAccount.Transactions)
        {
            Console.WriteLine(transaction);
        }
    }

}