using SalesManagement.Models;

namespace SalesManagement.Services
{
    public interface IProductService
    {
        void AddNewProduct(Product product);
        void AddNewProduct(string name, decimal price, int quantity);
        void UpdateProductById(Guid productId, Product product);
        void UpdateProductQuantityInStock(Guid productId, int quantity);
        List<Product> GetAllProducts();
        Product GetProductById(Guid productId);
        void DeleteProductById(Guid productId);
    }
}
