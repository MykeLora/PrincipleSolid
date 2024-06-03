public class CurrentAccount : BankAccounts
{
    public decimal OverdraftLimit { get; set; }
    public CurrentAccount(string accountNumber, decimal balance, decimal overdraftLimit)
     : base(accountNumber, balance)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if(amount <= Balance + OverdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine($"AccountNumber: {AccountNumber}, Exceeded Overdraft Limit.");
        }
        else
        {
            Console.WriteLine($"AccountNumber: {AccountNumber}, Exceeded Overdraft Limit.");
        }
    }

}
