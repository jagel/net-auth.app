using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Organizations.Interfaces;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users.Interfaces;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.UnitOfWorks.Interfaces
{
    public interface IUOInitialize
    {
        IGetUserRepository GetUser { get; }
        IRepositoryCreate<User> CreateUser { get; }
        IGetOrganizationRespository GetOrganization { get; }
        IRepositoryCreate<Organization> CreateOrganization { get; }
        IRepositoryCreate<OrganizationUser> CreateOrganizationUser { get; }
    }
}
