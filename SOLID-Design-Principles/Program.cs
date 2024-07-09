using System;
public class Program
{

    public static void Main(string[] args)
    {
        
       Television television = new Television();
       
       television.Play();
       television.ConnectToWifi("MyWifi");
       television.TurnOff();

        Radio radio = new Radio();
        radio.Play();
        radio.Tune(91.4);
        radio.TurnOff();

        SmartSpeaker smartSpeaker = new SmartSpeaker();
        smartSpeaker.Play();
        smartSpeaker.ConnectToWifi("MyWifi");
        smartSpeaker.TurnOff();

        Console.ReadKey();
    }

}