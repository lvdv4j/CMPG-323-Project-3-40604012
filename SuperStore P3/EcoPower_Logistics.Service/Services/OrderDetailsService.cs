using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Data.Repositories;

namespace EcoPower_Logistics.Service.Services
{
    // OrderDetailsService class implements the IOrderDetailsService interface.
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;

        // Constructor for OrderDetailsService that takes an IOrderDetailsRepository as a dependency.
        public OrderDetailsService(IOrderDetailsRepository orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }

        // Get an order detail by its ID.
        public OrderDetail GetOrderDetailById(int? id)
        {
            // Calls the GetOrderDetailById method from the injected IOrderDetailsRepository.
            return _orderDetailsRepository.GetOrderDetailById(id);
        }

        // Get all order details.
        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            // Calls the GetAllOrderDetails method from the injected IOrderDetailsRepository.
            return _orderDetailsRepository.GetAllOrderDetails();
        }

        // Add a new order detail.
        public void AddOrderDetail(OrderDetail entity)
        {
            // Calls the AddOrderDetail method from the injected IOrderDetailsRepository.
            _orderDetailsRepository.AddOrderDetail(entity);
        }

        // Update an existing order detail.
        public void UpdateOrderDetail(OrderDetail entity)
        {
            // Calls the UpdateOrderDetail method from the injected IOrderDetailsRepository.
            _orderDetailsRepository.UpdateOrderDetail(entity);
        }

        // Remove an order detail.
        public void RemoveOrderDetail(OrderDetail entity)
        {
            // Calls the RemoveOrderDetail method from the injected IOrderDetailsRepository.
            _orderDetailsRepository.RemoveOrderDetail(entity);
        }
    }
}
