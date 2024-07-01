public class HPLaserJetPrinter : IPrinterTasks, IPrintDuplexTasks, IFaxTasks
{
    public void Fax(string content)
    {
        Console.WriteLine("Fax content");
    }

    public void Print(string PrintContent)
    {
        Console.WriteLine("Print content");
    }

    public void PrintDuplex(string content)
    {
        Console.WriteLine("Print Duplex content");
    }

    public void Scan(string ScanContent)
    {
        Console.WriteLine("Scan content");
    }
}
