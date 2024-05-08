public class PaymentProcessor
{
    private readonly IPaymentStrategy paymentStrategy;

    public PaymentProcessor(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        this.paymentStrategy.ProcessPayment(amount);
    }
}