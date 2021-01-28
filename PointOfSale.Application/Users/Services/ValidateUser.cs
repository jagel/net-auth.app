using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using PointOfSale.Application.Common;
using PointOfSale.Application.Users.Interfaces;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users.Interfaces;
using System.Threading.Tasks;
using common = Common.Application.Exceptions;

namespace PointOfSale.Application.Users.Services
{
    public class ValidateUser : IValidateUser
    {
        private readonly IGetUserRepository getUser;

        public ValidateUser(IGetUserRepository getUser)
        {
            this.getUser = getUser;
        }


        public async Task<User> Login(string username, string password)
        {
            var user = await getUser.ByUserName(username);

            user = user?.Pasword == ConvertPasswordToHash(password) ? user : null;
            return user;
        }


        private string ConvertPasswordToHash(string password)
        {
            return password;
        }

    }
}
