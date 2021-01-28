using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Infrastructure.EntityFrameworkTools.Repository
{
    public abstract class GenericRepositoryCreate<TEntity, TDbContext> : BaseGenericRepository<TDbContext>, 
        IRepositoryCreate<TEntity>
        where TEntity : class, new()
        where TDbContext : DbContext
    {
        public GenericRepositoryCreate(TDbContext context) : base(context)
        {
        }

        public virtual async Task<TEntity> Handler(TEntity entity)
        {
            base.context.Set<TEntity>().Add(entity);

            await base.context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<ICollection<TEntity>> Handler(ICollection<TEntity> entity)
        {
            base.context.Set<TEntity>().AddRange(entity);

            await base.context.SaveChangesAsync();

            return entity;
        }
    }
}
