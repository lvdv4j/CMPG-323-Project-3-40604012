using Models;

namespace EcoPower_Logistics.Services
{
    public interface IProductService
    {
        Product GetProductById(short? id);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product entity);
        void UpdateProduct(Product entity);
        void RemoveProduct(Product entity);
    }
}
