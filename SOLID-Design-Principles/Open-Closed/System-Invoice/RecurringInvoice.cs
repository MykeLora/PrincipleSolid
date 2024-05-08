public class RecurringInvoice : BaseInvoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return base.GetInvoiceDiscount(amount) - 20;
    }
}