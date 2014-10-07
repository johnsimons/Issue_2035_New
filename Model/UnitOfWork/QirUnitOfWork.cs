using System.Threading;
using Model.Entity;
using Model.UnitOfWork.Interface;
using NServiceBus.Logging;

namespace Model.UnitOfWork
{
    public class QirUnitOfWork : IQirUnitOfWork
    {
        protected INorthWindDbContext qirCtx;

        protected static readonly ILog Logger = LogManager.GetLogger(typeof(QirUnitOfWork));

        public string DbConnectionString { get; set; }

        public QirUnitOfWork(IQirUnitOfWorkConfigProvider config)
        {
            DbConnectionString = config.DbConnectionString;
            qirCtx = new NorthWindDbContext(DbConnectionString);

            instance_num = Interlocked.Increment(ref num);

            Logger.InfoFormat("QirUnitOfWork ctor, {0}", instance_num);

        }

        public void Dispose()
        {
            if (qirCtx != null)
            {
                qirCtx.Dispose();
                Logger.InfoFormat("QirUnitOfWork dispose, {0}", instance_num);

            }
        }

        public INorthWindDbContext NorthWindDbContext
        {
            get { return qirCtx; }
        }

        public void SaveChanges()
        {
            qirCtx.SaveChanges();
        }

        private static int num;

        private int instance_num;

        public int Number
        {
            get { return instance_num; }
        }
    }
}
