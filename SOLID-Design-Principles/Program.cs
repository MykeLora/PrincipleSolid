using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var products = new List<Producto>
        {
            new Producto { Name = "Red Shirt", Color = "Red", Id = 10 },
            new Producto { Name = "Blue Pants", Color = "Blue", Id = 20 },
            new Producto { Name = "Computer", Color = "Black", Id = 12, Price = 25.69 },
            new Producto { Name = "Phone", Color = "Orange", Id = 32, Price = 12.43 },
            new Producto { Name = "KeyBoar", Color = "blue", Id = 10 },
            new Producto { Name = "Blue Pants", Color = "Blue", Id = 20 },
            
        };
        
        var filter = new ProductFilter();
        foreach (var product in filter.Filter(products, new NameSpecification("Phone")))
        {
            Console.WriteLine($"- {product.Name} \n {product.Color} \n  {product.Price}");
        }
            
        Console.ReadKey();
    }
}