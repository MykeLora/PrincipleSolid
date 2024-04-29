public class BankAccount
{
    public int AccountNumber{ get; set; }
    public double Balance{get;set;}
    public List<string> Transactions = new List<string>();
    
    public BankAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Transactions.Add($"Deposited ${amount}. New Balance: ${Balance}");
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
        Transactions.Add($"Withdrew ${amount}. New Balance: ${Balance}");
    }
}