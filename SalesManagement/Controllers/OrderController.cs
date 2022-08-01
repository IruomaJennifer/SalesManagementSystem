using Microsoft.AspNetCore.Mvc;
using SalesManagement.Models;
using SalesManagement.Services;

namespace SalesManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private IOrderService orderDb;
        public OrderController(IOrderService db)
        {
            orderDb = db;
        }
        [HttpDelete]
        public IActionResult DeleteOrder(Guid orderId)
        {
            orderDb.DeleteOrder(orderId);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var orders = orderDb.GetAllOrders();
            return Ok(orders);
        }
        [HttpGet("order-id")]
        public IActionResult GetOrderById(Guid orderId)
        {
            var order = orderDb.GetOrderById(orderId);
            return Ok(order);
        }
        [HttpGet("customer-id")]
        public IActionResult GetOrdersByCustomerId(Guid customerId)
        {
            var orders = orderDb.GetOrdersByCustomerId(customerId);
            return Ok(orders);
        }
        [HttpPost]
        public IActionResult MakeOrder(Order order,Guid productId,Guid customerId)
        {
            orderDb.MakeOrder(order, productId, customerId);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateOrderById(Guid orderId, Order order)
        {
            orderDb.UpdateOrderById(orderId, order);
            return Ok();
        }
    }
}
