using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Order GetOrderById(short? id);
        IEnumerable<Order> GetAllOrders();
        void AddOrder(Order entity);
        void UpdateOrder(Order entity);
        void RemoveOrder(Order entity);

    }
}
