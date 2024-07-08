using System;
public class Program
{

    public static void Main(string[] args)
    {
        Duck duck = new Duck();
        duck.Walk();
        duck.Swim();
        duck.Fly();

        Cats cat = new Cats();
        cat.Walk(); 
        Console.ReadKey();
    }

}