using static SalesManagement.Models.enums;

namespace SalesManagement.Models
{
    public class Sale
    {
        public Sale()
        {
            SaleId = Guid.NewGuid();
        }
        public Guid SaleId { get; }
        public DateTime DateOfSale = DateTime.Now;
        public List<Order> Orders { get; set; }
        //no customer needed here
        public decimal Payment { get; set; }
        public Status SaleStatus { get; set; } = Status.Open;
    }
}
