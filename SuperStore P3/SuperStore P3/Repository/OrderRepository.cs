using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepository
    {
        private readonly SuperStoreContext _context;

        public OrdersRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.FirstOrDefault(p => p.OrderId == id);
        }

        public void Create(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var order = _context.Orders.FirstOrDefault(p => p.OrderId == id);

            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _context.Orders.Any(p => p.OrderId == id);
        }
    }
}
