using SalesManagement.Models;
using static SalesManagement.Models.enums;

namespace SalesManagement.Services
{
    public interface ICustomerService
    {
        void CreateCustomer(Customer customer);
        void CreateCustomer(string fullName, string email, Gender gender);
        Customer GetCustomerById(Guid id);
        List<Customer> GetAllCustomers();
        void UpdateCustomerInfo(Guid id, Customer customer);
        void DeleteCustomer(Guid id);
    }
}
