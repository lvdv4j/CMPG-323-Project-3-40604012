using Microsoft.EntityFrameworkCore;
using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    // CustomerRepository inherits from the GenericRepository class with Customer as the generic type.
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SuperStoreContext context) : base(context)
        {
        }

        // Get a customer by their ID.
        public Customer GetCustomerById(short? id)
        {
            // Calls the inherited GetById method to retrieve a customer by ID.
            return GetById(id.Value);
        }

        // Get all customers.
        public IEnumerable<Customer> GetAllCustomer()
        {
            // Calls the inherited GetAll method and converts the result to a list.
            return GetAll().ToList();
        }

        // Add a new customer.
        public void AddCustomer(Customer entity)
        {
            // Calls the inherited Add method to add a new customer entity.
            Add(entity);
        }

        // Update an existing customer.
        public void UpdateCustomer(Customer entity)
        {
            // Calls the inherited Update method to update an existing customer entity.
            Update(entity);
        }

        // Remove a customer.
        public void RemoveCustomer(Customer entity)
        {
            // Calls the inherited Remove method to remove a customer entity.
            Remove(entity);
        }
    }
}
