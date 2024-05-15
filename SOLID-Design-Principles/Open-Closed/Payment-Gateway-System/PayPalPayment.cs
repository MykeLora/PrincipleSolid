public class PayPalPyment : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment for amount: {amount}");
    }
}
