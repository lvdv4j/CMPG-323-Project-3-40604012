using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order GetOrderById(int? id)
        {
            return _orderRepository.GetOrderById(id);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public void AddOrder(Order entity)
        {
            _orderRepository.AddOrder(entity);
        }

        public void UpdateOrder(Order entity)
        {
            _orderRepository.UpdateOrder(entity);
        }

        public void RemoveOrder(Order entity)
        {
            _orderRepository.RemoveOrder(entity);
        }
    }
}
