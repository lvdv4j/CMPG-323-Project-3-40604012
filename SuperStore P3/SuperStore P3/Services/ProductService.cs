using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProductById(short? id)
        {
            return _productRepository.GetProductById(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public void AddProduct(Product entity)
        {
            _productRepository.AddProduct(entity);
        }

        public void UpdateProduct(Product entity)
        {
            _productRepository.UpdateProduct(entity);
        }

        public void RemoveProduct(Product entity)
        {
            _productRepository.RemoveProduct(entity);
        }
    }
}
