using Data;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository
    {
        private readonly SuperStoreContext _context;

        public ProductRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                //TODO: ADD ERROR HANDLING FOR FOREIGN KEY CONSTRAINTS
            }
        }

        public bool Exists(int id)
        {
            return _context.Products.Any(p => p.ProductId == id);
        }
    }
}
