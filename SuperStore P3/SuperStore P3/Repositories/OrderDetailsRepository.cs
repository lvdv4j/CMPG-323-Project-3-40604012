using Microsoft.EntityFrameworkCore;
using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {

        public OrderDetailsRepository(SuperStoreContext context) : base(context)
        {
        }

        public OrderDetail GetOrderDetailById(short? id)
        {
            return GetById(id.Value);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return GetAll().ToList();
        }

        public void AddOrderDetail(OrderDetail entity)
        {
            Add(entity);
        }

        public void UpdateOrderDetail(OrderDetail entity)
        {
            Update(entity);
        }

        public void RemoveOrderDetail(OrderDetail entity)
        {
            Remove(entity);
        }

    }
}
