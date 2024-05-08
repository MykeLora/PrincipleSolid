public abstract class BaseInvoice
{
    public virtual double GetInvoiceDiscount(double amount)
    {
        return amount - 10;
    }
}
