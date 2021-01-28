using Common.Infrastructure.Common;
using Common.Infrastructure.EntityFrameworkTools.Repository;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Organizations
{
    public class CreateOrganization : GenericRepositoryCreate<Organization, PointOfSaleDbContext>
    {
        public CreateOrganization(PointOfSaleDbContext context): base(context)
        {
        }

        public override async Task<Organization> Handler(Organization entity)
        {
            var OrganizationPersisted = await base.context.Organization.Where(x => x.Token == entity.Token).FirstOrDefaultAsync();

            if (OrganizationPersisted != null)
                throw new InfrastructureException(new Common.Domain.Models.Response.ErrorResponse
                {
                    AddditionalInformation = "Organization with the same token is already created",
                    ApplicationName = "Point of sale",
                    MessageError = "Organization already exist",
                    Origin = "Persisting information",
                    ResponseCode = System.Net.HttpStatusCode.Conflict
                });

            base.context.Add(entity);
            await base.context.SaveChangesAsync();
            return entity;
        }
    }
}
