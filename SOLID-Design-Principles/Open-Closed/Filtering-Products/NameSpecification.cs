public class NameSpecification : ISpecification<Producto>
{
    private readonly string name;

    public NameSpecification( string name)
    {
        this.name = name;
    }

    public bool IsSatisfied(Producto item)
    {
        return item.Name == this.name;
    }
}