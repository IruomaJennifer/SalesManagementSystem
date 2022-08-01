using SalesManagement.Models;

namespace SalesManagement.Services
{
    public class SalesService : ISaleService
    {
        private static List<Sale> sales = new List<Sale>();

        public void CreateSale(Sale sale)
        {
            foreach (var order in sale.Orders)
            {
                OrderService.orders.Add(order);
            }
            sales.Add(sale);
        }

        public void CreateSaleFromExistingOrders(Sale sale, Guid customerId)
        {
            foreach (var order in OrderService.orders)
            {
                if (order.Customer.Id == customerId)
                    sale.Orders.Add(order);
            }
            sales.Add(sale);
        }

        public void DeleteSaleRecord(Guid saleid)
        {
            var sale = sales.FirstOrDefault(sale => sale.SaleId == saleid);
            if (sale is not null)
                sales.Remove(sale);
            else
                throw new Exception("No record of this sale exists");
        }

        public List<Sale> GetAllSales()
        {
            return sales;
        }

        public List<Order> GetOrdersFromSaleId(Guid saleid)
        {
            var sale = sales.FirstOrDefault(s => s.SaleId == saleid);
            if (sale != null)
                return sale.Orders;
            throw new Exception("No record of Sale");
        }

        public Sale GetSaleById(Guid saleid)
        {
            var sale = sales.FirstOrDefault(sale => sale.SaleId == saleid);
            if (sale is not null)
                return sale;
            throw new Exception("Sale not Found");
        }

        public void UpdateMerchandiseFromId(Guid saleId)
        {
            var sale = sales.FirstOrDefault(x => x.SaleId == saleId);
            if (sale is not null)
            {
                for (int p = 0; p < sale.Orders.Count; p++)
                {
                    sale.Orders[p].Product.QuantityInStock -= sale.Orders[p].Quantity;
                }
            }
        }

        public void UpdateSalePayment(Guid saleid)
        {
            var sale = sales.FirstOrDefault(s => s.SaleId == saleid);
            if (sale is not null)
            {
                sale.Payment = 0;
                foreach (var order in sale.Orders)
                {
                    sale.Payment += order.Product.Price * order.Quantity;
                }
            }
        }

        public void UpdateSaleStatus(Guid saleid, enums.Status status)
        {
            var sale = sales.FirstOrDefault(s => s.SaleId == saleid);
            if (sale != null)
                sale.SaleStatus = enums.Status.Closed;
        }
    }
}
