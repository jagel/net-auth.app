using PointOfSale.Domain.EntityFramework.Entities;
using System.Threading.Tasks;

namespace PointOfSale.Application.Users.Interfaces
{
    public interface IValidateUser
    {

        public Task<User> Login(string user, string password);
        
    }
}
