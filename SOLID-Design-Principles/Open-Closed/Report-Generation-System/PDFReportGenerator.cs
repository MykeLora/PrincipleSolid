public class PDFReportGenerator : IReportGenerator
{
    public void GenerateReport(string data)
    {
        Console.WriteLine($"Generating PDF report with data: {data}");
    }
}
