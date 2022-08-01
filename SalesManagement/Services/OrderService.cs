using SalesManagement.Models;
using System.Runtime.InteropServices;

namespace SalesManagement.Services
{
    public class OrderService : IOrderService
    {
        public static List<Order> orders = new List<Order>();

        public void DeleteOrder(Guid orderId)
        {
            var order = orders.FirstOrDefault(x => x.OrderId == orderId);
            if (order is not null)
                orders.Remove(order);
            else
                throw new Exception("This order doesn't exist!");
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }

        public Order GetOrderById(Guid orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
                return (order);
            else
                throw new Exception("Order doesn't exist");
        }

        public List<Order> GetOrdersByCustomerId(Guid customerId)
        {
            List<Order> _orders = new();
            foreach (var order in orders)
            {
                if (order.Customer.Id == customerId)
                    _orders.Add(order);
            }
            return (_orders);
        }

        public void MakeOrder(Order order, Guid productId, [Optional]Guid customerId)
        {
            foreach (var product in ProductService.products)
            {
                if (product.Id == productId)
                    order.Product = product;
                else
                    throw new Exception("Product not in stock");
            }
            if (customerId != Guid.Empty)
            {
                foreach (var customer in CustomerService.customers)
                {
                    if (customer.Id == customerId)
                        order.Customer = customer;
                    else
                        throw new Exception("Please enter customer details in body");
                }
            }
            else if (order.Customer != null)
                CustomerService.customers.Add(order.Customer);
            orders.Add(order);
        }

        public void UpdateOrderById(Guid orderId, Order order)
        {
            var _order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (_order is not null)
            {
                _order.Product = order.Product;
                _order.Customer = order.Customer;
                _order.Quantity = order.Quantity;
            }
            else
                throw new Exception("This order doesn't exist");
        }
    }
}
