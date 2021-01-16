using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Common.Infrastructure.EntityFrameworkTools.Repository
{
    public abstract class GenericRepositoryGet<TEntity, TDbContext> : 
        BaseGenericRepository<TDbContext>, IRepository<TEntity>
            where TEntity : class, new()
            where TDbContext : DbContext
    {

        public GenericRepositoryGet(TDbContext dbContext) : base(dbContext)
        {
        }

        public virtual async Task<TEntity> Handler(object IdEntity)
        {
            return await Task.FromResult(await base.context.FindAsync<TEntity>(IdEntity));
        }
    }
}
