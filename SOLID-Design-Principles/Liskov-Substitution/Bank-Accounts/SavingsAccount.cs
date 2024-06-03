public class SavingsAccount : BankAccounts
{
    public decimal InterestRate { get; set; }
    public SavingsAccount(string accountNumber, decimal balance, decimal interestRate) 
    : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void Withdraw(decimal amount)
    {
        if(amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Insuficient Funds, Available Funds {Balance}");
        }
    }
}