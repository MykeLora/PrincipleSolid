public class OnlineOrder : IOnlineOrder
{
    public void GenerateReceipt()
    {
        Console.WriteLine("Processing Online Payment");
    }

    public void ProcessOnlinePayment()
    {
        Console.WriteLine("Generating Receipt");
    }
}
