internal class Program
{
   
    private static void Main(string[] args)
    {
        Employee Alexis = new Employee {Name = "Alexis", HoursWorked = 200, Pay = 8000};
        EmployeeReport report = new EmployeeReport(Alexis);

        string content = report.GenerateReportContent();

        ReportPrinter printer = new ReportPrinter();
        printer.Print(content);

        ReportPDFSaver pdfSaver = new ReportPDFSaver();
        pdfSaver.SaveAsPDFSaver(content, "reportSaved.pdf");
        Console.ReadKey();
    }
} 