using Models;

namespace EcoPower_Logistics.Services
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
