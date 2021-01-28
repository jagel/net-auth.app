using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Organizations;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Organizations.Interfaces;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.OrganizationUsers;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Users.Interfaces;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.UnitOfWorks.Interfaces;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.UnitOfWorks
{
    public class UOInitialize : IUOInitialize
    {
        private readonly PointOfSaleDbContext context;

        private readonly IGetUserRepository getUser;

        public IGetUserRepository GetUser
        {
            get => getUser ?? new GetUserRepository(context);
        }

        private readonly IRepositoryCreate<User> createUser;

        public IRepositoryCreate<User> CreateUser
        {
            get => createUser ?? new CreateUser(context);
        }

        private readonly IGetOrganizationRespository getOrganization;

        public IGetOrganizationRespository GetOrganization
        {
            get => getOrganization ?? new GetOrganizationRepository(context);
        }

        private readonly IRepositoryCreate<Organization> createOrganization;
        public IRepositoryCreate<Organization> CreateOrganization
        {
            get => createOrganization ?? new CreateOrganization(context);
        }

        private readonly IRepositoryCreate<OrganizationUser> createOrganizationUser;
        public IRepositoryCreate<OrganizationUser> CreateOrganizationUser
        {
            get => createOrganizationUser ?? new CreateOrganizationUser(context);
        }

        public UOInitialize(PointOfSaleDbContext dbContext)
        {
            this.context = dbContext;
        }
    }
}
