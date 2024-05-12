public class CSVReportGenerator : IReportGenerator
{
    public void GenerateReport(string data)
    {
        Console.WriteLine($"Generating CSV report with data: {data}");
    }
}
