using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Service.Services
{
    public interface IProductService
    {
        Product GetProductById(int? id);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product entity);
        void UpdateProduct(Product entity);
        void RemoveProduct(Product entity);
    }
}
