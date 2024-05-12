public class GroceriesTaxStrategy : ITaxStrategy
{
    public double CalculateTax(Product product)
    {
        return product.Price * 0.05;
    }
}
