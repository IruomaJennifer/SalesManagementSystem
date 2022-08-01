using Microsoft.AspNetCore.Mvc;
using SalesManagement.Models;
using SalesManagement.Services;

namespace SalesManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {
        public ISaleService _db;
       
        public SalesController(ISaleService db)
        {
            _db = db;
        }
        [HttpPost]
        public IActionResult CreateSale(Sale sale)
        {
            _db.CreateSale(sale);
            return Ok();
        }
        [HttpPost("order")]
        public IActionResult CreateSaleFromExistingOrders(Sale sale, Guid customerId)
        {
            _db.CreateSaleFromExistingOrders(sale, customerId);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSaleRecord(Guid saleid)
        {
            try
            {
                _db.DeleteSaleRecord(saleid);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllSales()
        {
            _db.GetAllSales();
            return Ok();
        }
       
        [HttpGet("sale/products/saleid")]
        public IActionResult GetOrdersFromSaleId(Guid saleid)
        {
            try
            {
                var products = _db.GetOrdersFromSaleId(saleid);
                return Ok(products);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return Ok();
        }
        [HttpGet("sale/id")]
        public IActionResult GetSaleById(Guid saleid)
        {
            try
            {
                var sale = _db.GetSaleById(saleid);
                return Ok(sale);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok();
            
        }
        [HttpPut("id")]
        public IActionResult UpdateMerchandiseFromId(Guid saleId)
        {
            _db.UpdateMerchandiseFromId(saleId);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSalePayment(Guid saleid)
        {
            _db.UpdateSalePayment(saleid);
            return Ok();
        }
        [HttpPut("status")]
        public IActionResult UpdateSaleStatus(Guid saleid, enums.Status status)
        {
            _db.UpdateSaleStatus(saleid, status);
            return Ok();
        }
    }
}
