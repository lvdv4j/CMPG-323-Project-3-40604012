using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository
    {
        private readonly SuperStoreContext _context;

        public CustomerRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public void Create(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _context.Customers.Any(c => c.CustomerId == id);
        }
    }
}
