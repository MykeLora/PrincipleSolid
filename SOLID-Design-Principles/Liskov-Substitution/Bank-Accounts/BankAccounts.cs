public class BankAccounts
{
    public string AccountNumber { get; set;}
    public decimal Balance { get; set;}
    
    public BankAccounts(
        string accountNumber,
        decimal balance)
    {
        AccountNumber = accountNumber;       
        Balance = balance;
    }

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposit: {amount}, Total Amount: {Balance}");
    }

    public virtual void Withdraw(decimal amount)
    {
        if(amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }
}