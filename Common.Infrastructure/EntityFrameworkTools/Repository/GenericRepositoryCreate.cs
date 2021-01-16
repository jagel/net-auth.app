using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infrastructure.EntityFrameworkTools.Repository
{
    public abstract class GenericRepositoryCreate<TEntity, TDbContext> : BaseGenericRepository<TDbContext>
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
    }
}
