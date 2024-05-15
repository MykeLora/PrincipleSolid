public class PaymentHandler
{
    private readonly IPaymentProcessor paymentProcessor;

    public PaymentHandler(IPaymentProcessor paymentProcessor)
    {
        this.paymentProcessor = paymentProcessor;
    }

    public void ExecutePayment(double amount)
    {
        this.paymentProcessor.ProcessPayment(amount);
    }
}