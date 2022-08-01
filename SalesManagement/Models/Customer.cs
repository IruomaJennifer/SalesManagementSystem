using static SalesManagement.Models.enums;

namespace SalesManagement.Models
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        

    }
}
