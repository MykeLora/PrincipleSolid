using System;
internal class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Dot();
        animal.MakeSound();

        animal = new Cat();
        animal.MakeSound();

        Console.ReadKey();
    }

}