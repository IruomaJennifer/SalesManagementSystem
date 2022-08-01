using SalesManagement.Models;

namespace SalesManagement.Services
{
    public class CustomerService : ICustomerService
    {
        public static List<Customer> customers = new List<Customer>();

        public void CreateCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void CreateCustomer(string fullName, string email, enums.Gender gender)
        {
            customers.Add(new Customer
            {
                Full_Name = fullName,
                Email = email,
                Gender = gender
            });
        }

        public void DeleteCustomer(Guid id)
        {
            var customer = customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
                customers.Remove(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public Customer GetCustomerById(Guid id)
        {
            var customer = customers.FirstOrDefault(cust => cust.Id == id);
            if (customer != null)
                return customer;
            throw new Exception("You have requested a nonexistent customer");
        }

        public void UpdateCustomerInfo(Guid id, Customer customer)
        {
            var _customer = customers.FirstOrDefault(c => c.Id == id);
            if (_customer is not null)
            {
                _customer.Full_Name = customer.Full_Name;
                _customer.Email = customer.Email;
                _customer.Gender = customer.Gender;
            }
            else
                throw new Exception("This customer does not exist!");

        }
    }
}
