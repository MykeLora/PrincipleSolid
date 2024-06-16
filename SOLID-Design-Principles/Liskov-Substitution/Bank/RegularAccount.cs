public class RegularAccount : Bank
{
    public override void Withdraw(double amount)
    {
        if(balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw: {amount}, Balance: {balance}");
        }
        else
        {
            Console.WriteLine($"Trying to Withdraw: {amount}, Insufficient Funds: Available Funds: {balance}");
        }
    }

    
}