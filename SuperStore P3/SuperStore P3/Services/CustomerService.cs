using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomerById(short? id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomer();
        }

        public void AddCustomer(Customer entity)
        {
            _customerRepository.AddCustomer(entity);
        }

        public void UpdateCustomer(Customer entity)
        {
            _customerRepository.UpdateCustomer(entity);
        }

        public void RemoveCustomer(Customer entity)
        {
            _customerRepository.RemoveCustomer(entity);
        }
    }
}
