using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.OrganizationUsers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Application.OrganizationUsers
{
    public static class OrganizationUSersServiceCollectionExtension
    {
        public static IServiceCollection AddOrganizationServiceCollection(this IServiceCollection services)
        {
            services.AddTransient<IRepositoryCreate<OrganizationUser>, CreateOrganizationUser>();

            return services;
        }
    }
}
