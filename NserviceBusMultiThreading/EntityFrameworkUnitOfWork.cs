using System;
using Model.UnitOfWork;
using Model.UnitOfWork.Interface;
using NServiceBus.Logging;
using NServiceBus.UnitOfWork;

namespace NserviceBusMultiThreading
{
    public class EntityFrameworkUnitOfWork : QirUnitOfWork, IManageUnitsOfWork
    {
        public EntityFrameworkUnitOfWork(IQirUnitOfWorkConfigProvider config)
            : base(config){}

        public void Begin()
        {
            
        }

        public void End(Exception exception = null)
        {
            try
            {
                if (exception != null)
                {
                    return;
                }

                SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Failed to SaveChanges: {0}", ex));
            }
            finally
            {
                Dispose();
            }
        }
    }
}
