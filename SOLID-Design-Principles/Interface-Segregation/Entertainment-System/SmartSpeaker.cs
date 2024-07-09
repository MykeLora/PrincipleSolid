 public class SmartSpeaker : IPlayable, ITurnOff, IWiffiConnectable
{
    public void Play()
    {
        Console.WriteLine("Smart Speaker Playing...");
    }

    public void TurnOff()
    {
        Console.WriteLine("Smart Speaker turned off.");
    }

    public void ConnectToWifi(string network)
    {
        Console.WriteLine("Connect Smart Speaker to Wi-Fi network.");
    }
}