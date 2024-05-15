public class BankTransferPayment : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
       Console.WriteLine($"Processing bank transfer for amount: {amount}");
    }
}
