using SalesManagement.Models;

namespace SalesManagement.Services
{
    public class ProductService : IProductService
    {
        public static List<Product> products = new List<Product>();

        public void AddNewProduct(Product product)
        {
            products.Add(product);
        }

        public void AddNewProduct(string name, decimal price, int quantity)
        {
            products.Add(new Product
            {
                Name = name,
                Price = price,
                QuantityInStock = quantity
            });
        }
        public void DeleteProductById(Guid productId)
        {
            var product = products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
                products.Remove(product);
            else
                throw new Exception("Product does not exist");
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(Guid productId)
        {
            var product = products.FirstOrDefault(product => product.Id == productId);
            if (product != null)
                return product;
            throw new Exception("Product not available");
        }

        public void UpdateProductById(Guid productId, Product product)
        {
            var _product = products.FirstOrDefault(p => p.Id == productId);
            if (_product is not null)
            {
                _product.Price = product.Price;
                _product.Description = product.Description;
                _product.Name = product.Name;
                _product.Category = product.Category;
                
            }
        }

        public void UpdateProductQuantityInStock(Guid productId, int quantity)
        {
            var product = products.FirstOrDefault(p => p.Id == productId);
            if (product is not null)
                product.QuantityInStock += quantity;
        }
    }
}
