using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
    public interface IOrderDetailsRepository : IGenericRepository<OrderDetail>
    {
        OrderDetail GetOrderDetailById(short? id);
        IEnumerable<OrderDetail> GetAllOrderDetails();
        void AddOrderDetail(OrderDetail entity);
        void UpdateOrderDetail(OrderDetail entity);
        void RemoveOrderDetail(OrderDetail entity);
    }
}
