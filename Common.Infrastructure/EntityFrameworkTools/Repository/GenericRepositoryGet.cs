using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Infrastructure.EntityFrameworkTools.Repository
{
    public abstract class GenericRepositoryGet<TEntity, TDbContext> : 
        BaseGenericRepository<TDbContext>, IRepositoryGetById<TEntity>
            where TEntity : class, new()
            where TDbContext : DbContext
    {

        public GenericRepositoryGet(TDbContext dbContext) : base(dbContext)
        {
        }

        public virtual async Task<TEntity> Handler(object IdEntity)
        {
            return await base.context.Set<TEntity>().FindAsync(IdEntity);
        }
    }
}
