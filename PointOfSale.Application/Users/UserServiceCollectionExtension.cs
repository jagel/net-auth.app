using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using PointOfSale.Application.Users.Interfaces;
using PointOfSale.Application.Users.Services;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users.Interfaces;

namespace PointOfSale.Application.Users
{
    public static class UserServiceCollectionExtension
    {
        public static IServiceCollection AddUsersInitialization(this IServiceCollection services)
        {
            services.AddTransient<IGetUserRepository, GetUserRepository>();

            services.AddTransient<IRepositoryCreate<User>, CreateUser>();

            services.AddTransient<IValidateUser,ValidateUser>();

            return services;
        }
    }
}
