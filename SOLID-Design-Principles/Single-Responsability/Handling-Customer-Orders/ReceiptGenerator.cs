public class ReceiptGenerator
{
  public string GenerateReceipt(Order order)
    {
        if (order == null || order.customer == null)
        {
            // Handle the case where order or customer is null
            return "Invalid order";
        }

        string customerName = order.customer.Name ?? "Unknown";
        double orderAmount = order.CalculateOrderAmount(); // Assuming CalculateOrderAmount() returns a double

        return $"Receipt for {customerName}: Total - {orderAmount}";
    }

}