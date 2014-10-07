
using System.Collections.Generic;

namespace Model.Infrastructure.Interface
{
    public interface IRepository<T> : IReadOnlyRepository<T>
        where T : class
    {
        T Add(T item);
        void SaveChanges();
        void Delete(T item);
    }
}
