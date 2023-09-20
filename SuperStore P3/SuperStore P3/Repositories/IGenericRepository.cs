using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(short id);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }

}
