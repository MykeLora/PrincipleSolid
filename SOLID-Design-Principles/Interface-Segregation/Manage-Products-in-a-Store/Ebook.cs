public class Ebook : IProducts, IDowloadable
{
  
    public void SetPrice(decimal price)
    {
        Console.WriteLine($"Price Set EBook: {price}");
    }

    public void GetDescription()
    {
        Console.WriteLine("Get Description: EBook");
    }

    public byte[] Dowload()
    {
        Console.WriteLine("Download EBook");
        return new byte[1000];
    }


}
