using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Organizations;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Organizations.Interfaces;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Application.Organizations
{
    public static class OrganizationServiceCollectionExtension
    {
        public static IServiceCollection AddOrganizationInitialization(this  IServiceCollection services)
        {
            services.AddTransient<IGetOrganizationRespository, GetOrganizationRepository>();
            services.AddTransient<IRepositoryCreate<Organization>, CreateOrganization>();

            return services;
        }
    }
}
