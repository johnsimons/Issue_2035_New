
using Model.Entity;

namespace Model.UnitOfWork.Interface
{
    public interface IQirUnitOfWork
    {
        INorthWindDbContext NorthWindDbContext { get; }
        string DbConnectionString { get; set; }
        void SaveChanges();

        int Number { get;}
    }
}
