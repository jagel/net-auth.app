using Common.Infrastructure.EntityFrameworkTools.Repository;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users
{
    public class CreateUser : GenericRepositoryCreate<User, PointOfSaleDbContext>
    {
        public CreateUser(PointOfSaleDbContext dbContext) : base(dbContext)
        {
        }
    }
}
