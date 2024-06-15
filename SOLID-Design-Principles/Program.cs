using System;
internal class Program
{
    public static void Main(string[] args)
    {
        var rect = new Rectangle{ Width = 2, Height = 3};
        rect.GetArea();
        rect.ChangeDimensions(rect, 4, 5);


        var square = new Square{ Slide = 2};
        square.GetArea();
        Console.ReadKey();
    }

}