
using System;
using System.Data.Entity;

namespace Model.Entity
{
    public partial interface INorthWindDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }

    public partial class NorthWindDbContext
    {
        partial void InitializePartial()
        {
            Database.SetInitializer<NorthWindDbContext>(null);
        }
    }

}
