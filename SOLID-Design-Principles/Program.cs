using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var pdfGenerator = new PDFReportGenerator();
        var service = new ReportGenerationService(pdfGenerator);
        service.GenerateReport("PDF Report Data");

        var csvGenerator = new CSVReportGenerator();
        service = new ReportGenerationService(csvGenerator);
        service.GenerateReport("CSV Report Data");
            
        Console.ReadKey();
    }
}