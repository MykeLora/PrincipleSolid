public class Television : IPlayable, ITurnOff, IWiffiConnectable
{

    public void Play()
    {
        Console.WriteLine("TV Playing..");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV turned off.");
    }
    public void ConnectToWifi(string network)
    {
        Console.WriteLine("Connect TV to wi-fi network.");
    }

}
