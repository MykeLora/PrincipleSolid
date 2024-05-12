public class TaxCalculator
{
    private readonly ITaxStrategy taxStrategy;

    public TaxCalculator(ITaxStrategy taxStrategy)
    {
        this.taxStrategy = taxStrategy;
    }

    public double CalculateTax(Product product)
    {
        return this.taxStrategy.CalculateTax(product);
    }
}