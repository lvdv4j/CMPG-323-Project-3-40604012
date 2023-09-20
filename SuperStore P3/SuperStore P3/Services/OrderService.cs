using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Services
{
    // OrderService class implements the IOrderService interface.
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        // Constructor for OrderService that takes an IOrderRepository as a dependency.
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // Get an order by its ID.
        public Order GetOrderById(short? id)
        {
            // Calls the GetOrderById method from the injected IOrderRepository.
            return _orderRepository.GetOrderById(id);
        }

        // Get all orders.
        public IEnumerable<Order> GetAllOrders()
        {
            // Calls the GetAllOrders method from the injected IOrderRepository.
            return _orderRepository.GetAllOrders();
        }

        // Add a new order.
        public void AddOrder(Order entity)
        {
            // Calls the AddOrder method from the injected IOrderRepository.
            _orderRepository.AddOrder(entity);
        }

        // Update an existing order.
        public void UpdateOrder(Order entity)
        {
            // Calls the UpdateOrder method from the injected IOrderRepository.
            _orderRepository.UpdateOrder(entity);
        }

        // Remove an order.
        public void RemoveOrder(Order entity)
        {
            // Calls the RemoveOrder method from the injected IOrderRepository.
            _orderRepository.RemoveOrder(entity);
        }
    }
}
