internal class Program
{
   
    private static void Main(string[] args)
    {
        
        BankAccount myke = new BankAccount(162316);
        myke.Deposit(4500);
        myke.Withdraw(1000);

        StatementPrinter print = new StatementPrinter();
        print.Print(myke);
        Console.ReadKey();
    }
} 