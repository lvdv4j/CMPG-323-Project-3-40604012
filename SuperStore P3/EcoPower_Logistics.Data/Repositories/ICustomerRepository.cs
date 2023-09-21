using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetCustomerById(short? id);
        IEnumerable<Customer> GetAllCustomer();
        void AddCustomer(Customer entity);
        void UpdateCustomer(Customer entity);
        void RemoveCustomer(Customer entity);
    }
}
