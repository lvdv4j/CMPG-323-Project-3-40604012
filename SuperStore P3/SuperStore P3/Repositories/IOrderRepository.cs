using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Order GetOrderById(int? id);
        IEnumerable<Order> GetAllOrders();
        void AddOrder(Order entity);
        void UpdateOrder(Order entity);
        void RemoveOrder(Order entity);

    }
}
