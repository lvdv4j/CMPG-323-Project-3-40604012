using Data;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {
        }

        public Product GetProductById(short? id)
        {
            return GetById(id.Value);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return GetAll().ToList();
        }

        public void AddProduct(Product entity)
        {
            Add(entity);
        }

        public void UpdateProduct(Product entity)
        {
            Update(entity);
        }

        public void RemoveProduct(Product entity)
        {
            Remove(entity);
        }
    }
}
