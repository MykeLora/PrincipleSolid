 public class Radio : IPlayable, ITurnable, ITurnOff
{
    public void Play()
    {
        Console.WriteLine("Radio Playing...");
    }
    public void TurnOff()
    {
        Console.WriteLine("Radio turned off.");
    }
    public void Tune(double frequency)
    {
        Console.WriteLine($"Radio tuned to {frequency} MHz.");
    }

}