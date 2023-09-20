using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Services
{
    // ProductService class implements the IProductService interface.
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        // Constructor for ProductService that takes an IProductRepository as a dependency.
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Get a product by its ID.
        public Product GetProductById(short? id)
        {
            // Calls the GetProductById method from the injected IProductRepository.
            return _productRepository.GetProductById(id);
        }

        // Get all products.
        public IEnumerable<Product> GetAllProducts()
        {
            // Calls the GetAllProducts method from the injected IProductRepository.
            return _productRepository.GetAllProducts();
        }

        // Add a new product.
        public void AddProduct(Product entity)
        {
            // Calls the AddProduct method from the injected IProductRepository.
            _productRepository.AddProduct(entity);
        }

        // Update an existing product.
        public void UpdateProduct(Product entity)
        {
            // Calls the UpdateProduct method from the injected IProductRepository.
            _productRepository.UpdateProduct(entity);
        }

        // Remove a product.
        public void RemoveProduct(Product entity)
        {
            // Calls the RemoveProduct method from the injected IProductRepository.
            _productRepository.RemoveProduct(entity);
        }
    }
}
