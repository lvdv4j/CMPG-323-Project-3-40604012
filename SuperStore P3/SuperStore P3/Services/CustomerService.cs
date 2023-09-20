using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Services
{
    // CustomerService class implements the ICustomerService interface.
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        // Constructor for CustomerService that takes an ICustomerRepository as a dependency.
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // Get a customer by their ID.
        public Customer GetCustomerById(short? id)
        {
            // Calls the GetCustomerById method from the injected ICustomerRepository.
            return _customerRepository.GetCustomerById(id);
        }

        // Get all customers.
        public IEnumerable<Customer> GetAllCustomers()
        {
            // Calls the GetAllCustomer method from the injected ICustomerRepository.
            return _customerRepository.GetAllCustomer();
        }

        // Add a new customer.
        public void AddCustomer(Customer entity)
        {
            // Calls the AddCustomer method from the injected ICustomerRepository.
            _customerRepository.AddCustomer(entity);
        }

        // Update an existing customer.
        public void UpdateCustomer(Customer entity)
        {
            // Calls the UpdateCustomer method from the injected ICustomerRepository.
            _customerRepository.UpdateCustomer(entity);
        }

        // Remove a customer.
        public void RemoveCustomer(Customer entity)
        {
            // Calls the RemoveCustomer method from the injected ICustomerRepository.
            _customerRepository.RemoveCustomer(entity);
        }
    }
}
