public class FixedTermDepositAccount : Bank
{
    private bool termEnded = false;
    public override void Withdraw(double amount)
    {
        if(!termEnded)
        {
            Console.WriteLine("Cannot withdraw from a fixed term deposit account until term ends");
        }
        else if(balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw: {amount}, Balance: {balance}");
        }
        else
        {
            Console.WriteLine($"Trying to withdraw: {amount}, Insufficient Funds, Available Funds: {balance}");

        }
    }
}
