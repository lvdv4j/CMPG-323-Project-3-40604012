using Microsoft.EntityFrameworkCore;
using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    // OrderRepository inherits from the GenericRepository class with Order as the generic type.
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SuperStoreContext context) : base(context)
        {
        }

        // Get an order by its ID.
        public Order GetOrderById(short? id)
        {
            // Calls the inherited GetById method to retrieve an order by ID.
            return GetById(id.Value);
        }

        // Get all orders.
        public IEnumerable<Order> GetAllOrders()
        {
            // Calls the inherited GetAll method and converts the result to a list.
            return GetAll().ToList();
        }

        // Add a new order.
        public void AddOrder(Order entity)
        {
            // Calls the inherited Add method to add a new order entity.
            Add(entity);
        }

        // Update an existing order.
        public void UpdateOrder(Order entity)
        {
            // Calls the inherited Update method to update an existing order entity.
            Update(entity);
        }

        // Remove an order.
        public void RemoveOrder(Order entity)
        {
            // Calls the inherited Remove method to remove an order entity.
            Remove(entity);
        }
    }
}
