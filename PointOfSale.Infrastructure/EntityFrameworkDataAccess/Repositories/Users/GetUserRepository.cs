using Common.Infrastructure.EntityFrameworkTools.Repository;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users
{
    public class GetUserRepository : BaseGenericRepository<PointOfSaleDbContext>, IGetUserRepository
    {
        public GetUserRepository(PointOfSaleDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<User> ByUserName(string username) =>
            await base.context.User.Where(x=>x.UserName == username).FirstOrDefaultAsync();
    }
}
