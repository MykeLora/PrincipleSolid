internal class Program
{
   
    private static void Main(string[] args)
    {
            Order newOrder = new Order();
            // Add items to the order
            List<OrderItem> Items = new List<OrderItem>()
            {
                new OrderItem(){ProductName = "Laptop", Price = 10000},
                new OrderItem(){ProductName = "Desktop", Price = 7000},
                new OrderItem(){ProductName = "Tab", Price = 3000}
            };
            newOrder.Items = Items;
            //set the customer...
            Customer customer = new Customer()
            {
                Name = "maycol lora",
                Email = "MAYCOL@gmaIL.COM"
            };
            newOrder.customer = customer;
            ReceiptGenerator receiptGen = new ReceiptGenerator();
            string receipt = receiptGen.GenerateReceipt(newOrder);
            Console.WriteLine(receipt);
            CustomerNotifier notifier = new CustomerNotifier();
            notifier.NotifyCustomer(newOrder);
        Console.ReadKey();
    }
} 