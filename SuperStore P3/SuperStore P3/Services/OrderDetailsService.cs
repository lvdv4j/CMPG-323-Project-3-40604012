using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Services
{
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;

        public OrderDetailsService(IOrderDetailsRepository orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }

        public OrderDetail GetOrderDetailById(short? id)
        {
            return _orderDetailsRepository.GetOrderDetailById(id);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _orderDetailsRepository.GetAllOrderDetails();
        }

        public void AddOrderDetail(OrderDetail entity)
        {
            _orderDetailsRepository.AddOrderDetail(entity);
        }

        public void UpdateOrderDetail(OrderDetail entity)
        {
            _orderDetailsRepository.UpdateOrderDetail(entity);
        }

        public void RemoveOrderDetail(OrderDetail entity)
        {
            _orderDetailsRepository.RemoveOrderDetail(entity);
        }
    }
}