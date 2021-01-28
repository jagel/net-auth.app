using Common.Infrastructure.EntityFrameworkTools.Repository;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.OrganizationUsers
{
    public class CreateOrganizationUser : GenericRepositoryCreate<OrganizationUser, PointOfSaleDbContext>
    {
        public CreateOrganizationUser(PointOfSaleDbContext context): base(context)
        {

        }
    }
}
