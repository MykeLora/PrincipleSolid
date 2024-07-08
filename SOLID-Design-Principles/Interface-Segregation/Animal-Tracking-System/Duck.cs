public class Duck : IWalker, ISwimmer, IFlyer
{
    public void Walk()
    {
        Console.WriteLine("Duck is walking.");
    }
    public void Swim()
    {
        Console.WriteLine("Duck is swimming.");
    }
    public void Fly()
    {
        Console.WriteLine("Duck is flying.");
    }
}
