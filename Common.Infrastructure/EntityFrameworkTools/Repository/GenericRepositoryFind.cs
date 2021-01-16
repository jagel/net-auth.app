using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Common.Infrastructure.EntityFrameworkTools.Repository
{
    public class GenericRepositoryFind<TEntity, TDbContext> : BaseGenericRepository<TDbContext>
        where TEntity : class, new()
        where TDbContext : DbContext
    {
        public GenericRepositoryFind(TDbContext dbContext) : base(dbContext)
        {
        }

        public virtual IEnumerable<TEntity> Handler(Expression<Func<TEntity,bool>> predicate)
        {
            return base.context.Set<TEntity>()
                .AsQueryable()
                .Where(predicate);
        }
    }
}
