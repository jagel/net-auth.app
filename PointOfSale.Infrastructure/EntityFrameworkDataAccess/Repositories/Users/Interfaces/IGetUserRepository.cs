using System.Threading.Tasks;
using entity = PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users.Interfaces
{
    public interface IGetUserRepository
    {
        public Task<entity.User> ByUserName(string username);
    }
}
