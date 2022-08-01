using Microsoft.AspNetCore.Mvc;
using SalesManagement.Models;
using SalesManagement.Services;

namespace SalesManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        public ICustomerService _databaseService;

        public CustomerController(ICustomerService databaseService)
        {
            _databaseService = databaseService;
        }
        [HttpPost("by-customer")]
        public IActionResult CreateCustomer(Customer customer)
        {
            _databaseService.CreateCustomer(customer);
            return Ok("A Customer was Created Successfully");
        }
        [HttpPost]
        public IActionResult CreateCustomer(string fullName, string email, enums.Gender gender)
        {
            _databaseService.CreateCustomer(fullName, email, gender);
            return Ok("A Customer was Created Successfully");
        }
        [HttpDelete]
        public IActionResult DeleteCustomer(Guid id)
        {
            _databaseService.DeleteCustomer(id);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = _databaseService.GetAllCustomers();
            return Ok(customers);
        }
        [HttpGet("customer/id")]
        public IActionResult GetCustomerById(Guid id)
        {
            try
            {
                var customer = _databaseService.GetCustomerById(id);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCustomerInfo(Guid id, Customer customer)
        {
            try
            {
                _databaseService.UpdateCustomerInfo(id, customer);
                return Ok("A customer was updated sucessfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok();
        }
    }
}
