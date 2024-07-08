using System;
public class Program
{

    public static void Main(string[] args)
    {

        Ebook ebook = new Ebook();
        ebook.SetPrice(1500);
        ebook.GetDescription();
        ebook.Dowload();

        TShirt shirt = new TShirt();
        shirt.SetPrice(2500);
        shirt.GetDescription();
        shirt.ShipTo("Address 1, City, Santo Domingo"); 
        Console.ReadKey();
    }

}