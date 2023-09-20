using Microsoft.EntityFrameworkCore;
using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetCustomerById(short? id)
        {
            return GetById(id.Value);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return GetAll().ToList();
        }

        public void AddCustomer(Customer entity)
        {
            Add(entity);
        }

        public void UpdateCustomer(Customer entity)
        {
            Update(entity);
        }

        public void RemoveCustomer(Customer entity)
        {
            Remove(entity);
        }
    }
}
