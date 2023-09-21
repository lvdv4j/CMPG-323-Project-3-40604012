using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Service.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int? id);
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer entity);
        void UpdateCustomer(Customer entity);
        void RemoveCustomer(Customer entity);
    }
}
