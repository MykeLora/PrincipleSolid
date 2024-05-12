public class ReportGenerationService
{
    private readonly IReportGenerator reportGenerator;

    public ReportGenerationService(IReportGenerator reportGenerator)
    {
        this.reportGenerator = reportGenerator;
    }

    public void GenerateReport(string data)
    {
        this.reportGenerator.GenerateReport(data);
    }
}