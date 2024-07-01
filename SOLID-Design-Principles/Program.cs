using System;
public class Program
{

    public static void Main(string[] args)
    {
        HPLaserJetPrinter hPLaser = new HPLaserJetPrinter();

        hPLaser.Print("Printing");
        hPLaser.Scan("Scannig");
        hPLaser.Fax("Faxing");
        hPLaser.PrintDuplex("PrintDuplex");

        LiquidInkjetPrinter liquidInkjet = new LiquidInkjetPrinter();
        
        liquidInkjet.Print("Printing");
        liquidInkjet.Scan("Scanning");
        
        Console.ReadKey();
    }

}