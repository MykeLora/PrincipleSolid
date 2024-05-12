public class ClothingTaxStrategy : ITaxStrategy
{
    public double CalculateTax(Product product)
    {
        return product.Price * 0.10;
    }
}
