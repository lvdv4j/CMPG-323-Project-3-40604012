using EcoPower_Logistics.Data.Data;
using EcoPower_Logistics.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EcoPower_Logistics.Data.Repositories
{
    // ProductRepository inherits from the GenericRepository class with Product as the generic type.
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {
        }

        // Get a product by its ID.
        public Product GetProductById(short? id)
        {
            // Calls the inherited GetById method to retrieve a product by ID.
            return GetById(id.Value);
        }

        // Get all products.
        public IEnumerable<Product> GetAllProducts()
        {
            // Calls the inherited GetAll method and converts the result to a list.
            return GetAll().ToList();
        }

        // Add a new product.
        public void AddProduct(Product entity)
        {
            // Calls the inherited Add method to add a new product entity.
            Add(entity);
        }

        // Update an existing product.
        public void UpdateProduct(Product entity)
        {
            // Calls the inherited Update method to update an existing product entity.
            Update(entity);
        }

        // Remove a product.
        public void RemoveProduct(Product entity)
        {
            // Calls the inherited Remove method to remove a product entity.
            Remove(entity);
        }
    }
}
