using Models;

namespace EcoPower_Logistics.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerById(short? id);
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer entity);
        void UpdateCustomer(Customer entity);
        void RemoveCustomer(Customer entity);
    }
}
