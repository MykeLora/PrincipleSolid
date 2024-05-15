using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var creditCardPayment = new CreditCarPayment();
        var handler = new PaymentHandler(creditCardPayment);
        handler.ExecutePayment(125.56);

        var paypalPayment = new PayPalPyment();
        handler = new PaymentHandler(paypalPayment);
        handler.ExecutePayment(150.85);

        Console.ReadKey();
    }
}