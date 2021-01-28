using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infrastructure.EntityFrameworkTools.Repository
{
    public class GenericRepositoryGetAll<TEntity,TDbContext>: BaseGenericRepository<TDbContext> , IRepositoryGetAll<TEntity>
        where TEntity : class, new()
        where TDbContext : DbContext
    {
        public GenericRepositoryGetAll(TDbContext  context): base(context)
        {
        }

        public async Task<IQueryable<TEntity>> Handler()
        {
            return await Task.FromResult(base.context.Set<TEntity>());
        }
    }
}
