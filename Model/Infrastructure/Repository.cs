using System;
using System.Data.Entity.Validation;
using System.Text;
using Model.Infrastructure.Interface;
using Model.UnitOfWork.Interface;

namespace Model.Infrastructure
{
    public class Repository<T> : ReadOnlyRepository<T>, IRepository<T>
        where T : class
    {
        public Repository(IQirUnitOfWork qirUnitOfWork): base(qirUnitOfWork)
        {
            if (qirUnitOfWork == null)
                throw new ArgumentNullException("unitOfWork");
        }

        public void SaveChanges()
        {
            try
            {
                QirUnitOfWork.NorthWindDbContext.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }
                throw new DbEntityValidationException("Entity Validation Failed - errors follow:\n" + sb, ex);
                // Add the original exception as the innerException
            }

        }

        public void Delete(T item)
        {
            throw new System.NotImplementedException();
        }

        public T Add(T item)
        {
            throw new System.NotImplementedException();
        }

    }
}
