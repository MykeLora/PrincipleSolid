public class CreditCarPayment : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment for amount: {amount}");
    }
}
