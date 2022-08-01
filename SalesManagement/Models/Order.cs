namespace SalesManagement.Models
{
    public class Order
    {
        public Order()
        {
            OrderId = Guid.NewGuid();
        }

        public Guid OrderId { get;}
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Customer Customer { get; set; }

    }
}
