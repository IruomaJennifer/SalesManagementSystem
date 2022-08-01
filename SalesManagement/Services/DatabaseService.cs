using SalesManagement.Models;

namespace SalesManagement.Services
{
    //public class DatabaseService : IDatabaseService
    //{
    //    List<Product> Products = new List<Product>();
    //    List<Customer> Customers = new List<Customer>();
    //    List<Sale> Sales = new List<Sale>();
    //    List<Order> Orders = new List<Order>();
    //    public void AddNewProduct(Product product)
    //    {
    //        Products.Add(product);
    //    }

    //    public void AddNewProduct(string name, decimal price, int quantity)
    //    {
    //        Products.Add(new Product
    //        {
    //            Name = name,
    //            Price = price,
    //            QuantityInStock = quantity
    //        });
    //    }

    //    public void CreateCustomer(Customer customer)
    //    {
    //        Customers.Add(customer);
    //    }

    //    public void CreateCustomer(string fullName, string email, enums.Gender gender)
    //    {
    //        Customers.Add(new Customer
    //        {
    //            Full_Name = fullName,
    //            Email = email,
    //            Gender = gender
    //        });
    //    }
    //    //create a list of orders
    //    //create an order
    //    public void CreateSale(Sale sale)
    //    {
            
    //        for (int p = 0; p < sale.Orders.Count; p++)
    //        {
    //            sale.Orders[p].Product.QuantityInStock -= sale.Orders[p].Quantity;
    //        }
    //        Sales.Add(sale);
    //    }

    //    public void DeleteCustomer(Guid id)
    //    {
    //        var customer = Customers.FirstOrDefault(x => x.Id == id);
    //        if (customer != null)
    //            Customers.Remove(customer);
    //    }

    //    public void DeleteProductById(Guid productId)
    //    {
    //        var product = Products.FirstOrDefault(p => p.Id == productId);
    //        if (product != null)
    //            Products.Remove(product);
    //    }

    //    public void DeleteSaleRecord(Guid saleid)
    //    {
    //        var sale = Sales.FirstOrDefault(sale => sale.SaleId == saleid);
    //        if (sale is not null)
    //            Sales.Remove(sale);
    //    }

    //    public List<Customer> GetAllCustomers()
    //    {
    //        return Customers;
    //    }

    //    public List<Product> GetAllProducts()
    //    {
    //        return Products;
    //    }

    //    public List<Sale> GetAllSales()
    //    {
    //        return Sales;
    //    }

    //    public Customer GetCustomerById(Guid id)
    //    {
    //        var customer = Customers.FirstOrDefault(cust => cust.Id == id);
    //        if (customer != null)
    //            return customer;
    //        throw new Exception("You have requested a nonexistent customer");
    //    }

    //    public Customer GetCustomerFromSale(Guid saleid)
    //    {
    //        var sale = Sales.FirstOrDefault(sale => sale.SaleId == saleid);
    //        if (sale != null)
    //            return sale.Customer;
    //        throw new Exception("There is no such sale record");
    //    }

    //    public Product GetProductById(Guid productId)
    //    {
    //        var product = Products.FirstOrDefault(product => product.Id == productId);
    //        if (product != null)
    //            return product;
    //        throw new Exception("Product not available");
    //    }

    //    public List<Order> GetOrdersFromSaleId(Guid saleid)
    //    {
    //        var sale = Sales.FirstOrDefault(s => s.SaleId == saleid);
    //        if (sale != null)
    //            return sale.Orders;
    //        throw new Exception("No record of Sale");
    //    }

    //    public Sale GetSaleById(Guid saleid)
    //    {
    //        var sale = Sales.FirstOrDefault(sale => sale.SaleId == saleid);
    //        if (sale is not null)
    //            return sale;
    //        throw new Exception("Sale not Found");
    //    }

    //    public void UpdateCustomerInfo(Guid id, Customer customer)
    //    {
    //        var _customer = Customers.FirstOrDefault(c => c.Id == id);
    //        if (_customer is not null)
    //        {
    //            _customer.Full_Name = customer.Full_Name;
    //            _customer.Email = customer.Email;
    //            _customer.Gender = customer.Gender;
    //        }

    //    }

    //    public void UpdateProductById(Guid productId, Product product)
    //    {
    //        var _product = Products.FirstOrDefault(p => p.Id == productId);
    //        if (_product is not null)
    //        {
    //            _product.Price = product.Price;
    //            _product.Description = product.Description;
    //            _product.Name = product.Name;
    //            _product.Category = product.Category;
    //        }
    //    }

    //    public void UpdateProductQuantityInStock(Guid productId, int quantity)
    //    {
    //        var product = Products.FirstOrDefault(p => p.Id == productId);
    //        if (product is not null)
    //            product.QuantityInStock += quantity;
    //    }

    //    public void UpdateSalePayment(Guid saleid)
    //    {
    //        var sale = Sales.FirstOrDefault(s => s.SaleId == saleid); 
    //        if (sale is not null)
    //        {
    //            sale.Payment = 0;
    //            foreach (var order in sale.Orders)
    //            {
    //                sale.Payment += order.Product.Price * order.Quantity;
    //            }
    //        }
    //    }

    //    public void UpdateSaleStatus(Guid saleid, enums.Status status)
    //    {
    //        var sale = Sales.FirstOrDefault(s => s.SaleId == saleid);
    //        if (sale != null)
    //            sale.SaleStatus = enums.Status.Closed;
    //    }
    //}
}
