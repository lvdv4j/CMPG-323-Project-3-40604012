using Microsoft.EntityFrameworkCore;
using EcoPower_Logistics.Data.Data;
using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
    // OrderDetailsRepository inherits from the GenericRepository class with OrderDetail as the generic type.
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(SuperStoreContext context) : base(context)
        {
        }

        // Get an order detail by its ID.
        public OrderDetail GetOrderDetailById(short? id)
        {
            // Calls the inherited GetById method to retrieve an order detail by ID.
            return GetById(id.Value);
        }

        // Get all order details.
        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            // Calls the inherited GetAll method and converts the result to a list.
            return GetAll().ToList();
        }

        // Add a new order detail.
        public void AddOrderDetail(OrderDetail entity)
        {
            // Calls the inherited Add method to add a new order detail entity.
            Add(entity);
        }

        // Update an existing order detail.
        public void UpdateOrderDetail(OrderDetail entity)
        {
            // Calls the inherited Update method to update an existing order detail entity.
            Update(entity);
        }

        // Remove an order detail.
        public void RemoveOrderDetail(OrderDetail entity)
        {
            // Calls the inherited Remove method to remove an order detail entity.
            Remove(entity);
        }
    }
}
