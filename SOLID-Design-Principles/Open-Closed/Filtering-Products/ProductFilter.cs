
public class ProductFilter : IFilter<Producto>
{
    public IEnumerable<Producto> Filter(IEnumerable<Producto> items, ISpecification<Producto> spec)
    {
       return items.Where(p => spec.IsSatisfied(p));
    }
}

