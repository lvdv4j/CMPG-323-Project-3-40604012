using Models;

namespace EcoPower_Logistics.Services
{
    public interface IOrderDetailsService
    {
        OrderDetail GetOrderDetailById(short? id);
        IEnumerable<OrderDetail> GetAllOrderDetails();
        void AddOrderDetail(OrderDetail entity);
        void UpdateOrderDetail(OrderDetail entity);
        void RemoveOrderDetail(OrderDetail entity);
    }
}
