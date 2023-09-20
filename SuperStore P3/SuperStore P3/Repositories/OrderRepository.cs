using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepository
    {
        public class OrderRepository : GenericRepository<Order>, IOrderRepository
        {
            public OrderRepository(SuperStoreContext context) : base(context)
            {
            }

            public Order GetOrderById(int? id)
            {
                return GetById(id.Value);
            }

            public IEnumerable<Order> GetAllOrders()
            {
                return GetAll().ToList();
            }

            public void AddOrder(Order entity)
            {
                Add(entity);
            }

            public void UpdateOrder(Order entity)
            {
                Update(entity);
            }

            public void RemoveOrder(Order entity)
            {
                Remove(entity);
            }
        }
    }
}
