  public class IdSpecification : ISpecification<Producto>
{
    private readonly int id;
    public IdSpecification(int id)
    {
        this.id = id;
    }
    public bool IsSatisfied(Producto p)
    {
        return p.Id == id;
    }
}