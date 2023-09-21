using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Service.Services
{
    public interface IOrderDetailsService
    {
        OrderDetail GetOrderDetailById(int? id);
        IEnumerable<OrderDetail> GetAllOrderDetails();
        void AddOrderDetail(OrderDetail entity);
        void UpdateOrderDetail(OrderDetail entity);
        void RemoveOrderDetail(OrderDetail entity);
    }
}
