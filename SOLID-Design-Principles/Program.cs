internal class Program
{
   
    private static void Main(string[] args)
    {
        
        var logger = new Logger();

        var mailSender = new MailSender();

        var invoice = new Invoice(logger, mailSender);

        invoice.AddInvoice();
        invoice.DeleteInvoice();
    }
}