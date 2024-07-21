public class PaymentProcesor
{
    private readonly IPaymentMethod _paymentMethod;

    public PaymentProcesor(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void ExecutePayment(decimal amount)
    {
        _paymentMethod.ProcessPayment(amount);
    }
}