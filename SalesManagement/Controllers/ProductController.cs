using Microsoft.AspNetCore.Mvc;
using SalesManagement.Models;
using SalesManagement.Services;

namespace SalesManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public IProductService _dbservice;
        public ProductController(IProductService db)
        {
            _dbservice = db;
        }
        [HttpPost("product")]
        public IActionResult AddNewProduct(Product product)
        {
            _dbservice.AddNewProduct(product);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddNewProduct(string name, decimal price, int quantity)
        {
            _dbservice.AddNewProduct(name, price, quantity);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteProductById(Guid productId)
        {
            try
            {
                _dbservice.DeleteProductById(productId);
                return Ok();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _dbservice.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("id")]
        public IActionResult GetProductById(Guid productId)
        {
            try
            {
                var product = _dbservice.GetProductById(productId);
                return Ok(product);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok();
        }
        [HttpPut("update/product")]
        public IActionResult UpdateProductById(Guid productId, Product product)
        {
            _dbservice.UpdateProductById(productId, product);
            return Ok();
        }
        [HttpPut("update/product/quantity")]
        public IActionResult UpdateProductQuantityInStock(Guid productId, int quantity)
        {
           _dbservice.UpdateProductQuantityInStock(productId, quantity);
            return Ok();
        }
    }
}
