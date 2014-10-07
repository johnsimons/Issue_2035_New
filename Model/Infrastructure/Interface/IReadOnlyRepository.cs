
namespace Model.Infrastructure.Interface
{
    using System.Collections.Generic;
    using System.Linq;

    // Interfaces
    public interface IReadOnlyRepository<T>
        where T : class
    {
        IQueryable<T> AllQuerable();
        IList<T> ListAll();
        T FirstById(int id);
    }
}
