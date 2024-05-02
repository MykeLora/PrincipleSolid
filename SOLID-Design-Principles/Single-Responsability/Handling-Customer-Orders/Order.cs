public class Order
{
    public List<OrderItem> Items { get;set;} = new List<OrderItem>();
    public Customer? customer {get;set;}

    public double CalculateOrderAmount()
    {
        return Items.Sum(item => item.Price);
    }
}