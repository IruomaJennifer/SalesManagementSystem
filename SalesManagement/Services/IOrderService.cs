using SalesManagement.Models;

namespace SalesManagement.Services
{
    public interface IOrderService
    {
        void MakeOrder(Order order,Guid productId, Guid customerId);
        void DeleteOrder(Guid orderId);
        void UpdateOrderById(Guid orderId, Order order);
        List<Order> GetAllOrders();
        List<Order> GetOrdersByCustomerId(Guid customerId);
        Order GetOrderById(Guid orderId);
    }
}
