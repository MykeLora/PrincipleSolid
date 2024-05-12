public class XMLReportGenerator : IReportGenerator
{
    public void GenerateReport(string data)
    {
        Console.WriteLine($"Generating XML report with data: {data}");
    }
}
