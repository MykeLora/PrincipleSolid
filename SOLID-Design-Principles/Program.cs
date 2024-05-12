using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var electronicsProduct = new Product
        {
            Name = "Laptop",
            Price = 24000,
            category = ProductCategory.Electronics

        };

        var taxCalculator = new TaxCalculator(new ElectronicsTaxStrategy());
        Console.WriteLine($"Tax for {electronicsProduct.Name}: ${taxCalculator.CalculateTax(electronicsProduct)}");

        Console.ReadKey();
    }
}