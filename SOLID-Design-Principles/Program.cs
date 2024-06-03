using System;
internal class Program
{
    public static void Main(string[] args)
    {
        IFruit fruit = new Orange();
        Console.WriteLine($"Color of Orange: {fruit.GetColor()}");

        fruit = new Apple();
        Console.WriteLine($"Color of Apple: {fruit.GetColor()}");

        fruit = new Banana();
        Console.WriteLine($"Color of Banana: {fruit.GetColor()}");

        Console.ReadKey();
    }
}