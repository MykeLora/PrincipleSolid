using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Invoice Amount: 40000");

        BaseInvoice FInvoice = new FinalInvoice();
        
        double FInvoiceAmount = FInvoice.GetInvoiceDiscount(40000);
        Console.WriteLine($"Final Invoive : {FInvoiceAmount}");

        BaseInvoice PInvoice = new ProposedInvoice();

        double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
        Console.WriteLine($"Proposed Invoive : {PInvoiceAmount}");

        BaseInvoice RInvoice = new RecurringInvoice();
        double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
        Console.WriteLine($"Recurring Invoive : {RInvoiceAmount}");

        Console.ReadKey();
    }
}