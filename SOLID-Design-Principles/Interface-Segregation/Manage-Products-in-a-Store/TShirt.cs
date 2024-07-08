public class TShirt : IProducts, IShippable
{
    public void GetDescription()
    {
        Console.WriteLine("Get Description : TShirt");
    }

    public void SetPrice(decimal price)
    {
        Console.WriteLine($"Price Set TShirt: {price}");
    }

    public void ShipTo(string address)
    {
        Console.WriteLine($"TShirt ShipTo : {address}");
    }
}
