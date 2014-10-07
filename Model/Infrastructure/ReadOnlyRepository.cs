using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Model.Infrastructure.Interface;
using Model.UnitOfWork.Interface;

namespace Model.Infrastructure
{
    public class ReadOnlyRepository<T> : IReadOnlyRepository<T>
        where T : class
    {
        protected readonly IQirUnitOfWork QirUnitOfWork;
        internal DbSet<T> DbSet { get; set; }

        public ReadOnlyRepository(IQirUnitOfWork qirUnitOfWork)
        {
            if (qirUnitOfWork == null) throw new ArgumentNullException("qirUnitOfWork");
            QirUnitOfWork = qirUnitOfWork;
            DbSet = QirUnitOfWork.NorthWindDbContext.Set<T>();
        }

        public IQueryable<T> AllQuerable()
        {
            return DbSet.AsQueryable();
        }

        public IList<T> ListAll()
        {
            return DbSet.ToList();
        }

        public T FirstById(int id)
        {
            return DbSet.Find(id);
        }
    }
}
