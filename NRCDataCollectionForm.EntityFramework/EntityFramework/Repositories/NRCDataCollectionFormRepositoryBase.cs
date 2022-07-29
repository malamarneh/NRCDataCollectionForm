using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace NRCDataCollectionForm.EntityFramework.Repositories
{
    public abstract class NRCDataCollectionFormRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<NRCDataCollectionFormDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected NRCDataCollectionFormRepositoryBase(IDbContextProvider<NRCDataCollectionFormDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class NRCDataCollectionFormRepositoryBase<TEntity> : NRCDataCollectionFormRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected NRCDataCollectionFormRepositoryBase(IDbContextProvider<NRCDataCollectionFormDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
