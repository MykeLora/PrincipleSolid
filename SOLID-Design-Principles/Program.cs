using System;
public class Program
{

    public static void Main(string[] args)
    {
        
        Console.WriteLine("OnlineOrder:");
        OnlineOrder onlineOrder = new OnlineOrder();
        onlineOrder.ProcessOnlinePayment();
        onlineOrder.GenerateReceipt();

        Console.WriteLine("\nInHouseOrder:");
        InHouseOrder inHouse = new InHouseOrder();
        inHouse.PrintTicket();

        Console.WriteLine("\nPhoneOrder:");
        PhoneOrder phoneOrder = new PhoneOrder();
        phoneOrder.ConfirmOverPhone();
        
        Console.ReadKey();
    }

}