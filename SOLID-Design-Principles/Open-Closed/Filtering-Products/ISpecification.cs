public interface ISpecification<T> where T : class
{
    bool IsSatisfied(T item);
}