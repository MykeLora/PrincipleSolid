using System;
public class Program
{

    public static void Main(string[] args)
    {
        var creditCardPayment = new CreditCard();
        var paymentProcessor1 = new PaymentProcesor(creditCardPayment);
        paymentProcessor1.ExecutePayment(100m);
        
        var paypalPayment = new PayPal();
        var paymentProcesor2 = new PaymentProcesor(paypalPayment);
        paymentProcesor2.ExecutePayment(300m);
                
        Console.ReadKey();
    }

}