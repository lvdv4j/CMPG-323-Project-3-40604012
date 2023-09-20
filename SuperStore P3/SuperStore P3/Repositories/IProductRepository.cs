using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetProductById(short? id);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product entity);
        void UpdateProduct(Product entity);
        void RemoveProduct(Product entity);
    }
}
