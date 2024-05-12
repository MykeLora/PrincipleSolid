public class ElectronicsTaxStrategy : ITaxStrategy
{
    public double CalculateTax(Product product)
    {
        return product.Price * 0.15;
    }
}