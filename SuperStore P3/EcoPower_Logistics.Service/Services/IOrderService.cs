using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Service.Services
{
    public interface IOrderService
    {
        Order GetOrderById(int? id);
        IEnumerable<Order> GetAllOrders();
        void AddOrder(Order entity);
        void UpdateOrder(Order entity);
        void RemoveOrder(Order entity);
    }
}
