using PointOfSale.Application.Common.Initialize.Interfaces;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.UnitOfWorks.Interfaces;
using PointOfSale.Domain.EntityFramework.Entities;
using System.Threading.Tasks;
using Common.Domain.Definitions;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PointOfSale.Application.Common.Initialize.Services
{
    public class InitializePointOfSale : IInitializePointOfSale
    {
        private readonly IUOInitialize intializeDatabase;

        public InitializePointOfSale(IUOInitialize IntializeDatabase)
        {
            intializeDatabase = IntializeDatabase;
        }

        public async Task InitializeDatabase()
        {
            var usersIds = await CreateAndGetUsersIds();
            var organizationId = await CreateOrGetOrganization();
            await MergeOrganizationAndUser(usersIds, organizationId);
        }

        private async Task<int[]> CreateAndGetUsersIds()
        {
            string username = "jagel";
            var user = await intializeDatabase.GetUser.ByUserName(username);
            if (user == null)
            {
                user = await intializeDatabase.CreateUser.Handler(new User
                {
                    Status = EDB_ItemStatus.Active,
                    CreatedDate = DateTime.Now,
                    Email = "registeredemail@mail.com",
                    Pasword = "myStrongPassword",
                    Token = "hereIsTheToken",
                    UserName = username,
                });
            }

            return new int[] { user.Id };
        }

        private async Task<int> CreateOrGetOrganization()
        {
            Guid guid = new Guid("4298425a-a563-4f2a-b886-ccc8e501e78b");
            var organization = await intializeDatabase.GetOrganization.GetOrganizationByGuid(guid).FirstOrDefaultAsync();
            
            if (organization == null)
            {
                organization = await intializeDatabase.CreateOrganization.Handler(new Organization
                {
                    Status = EDB_ItemStatus.Active,
                    CreatedDate = DateTime.Now,
                    Description = "Development Organization",
                    IsPrimary = true,
                    Name = "Admin Organization",
                    Token = guid,
                });
            }

            return organization.Id;
        }

        private async Task MergeOrganizationAndUser(int[] usersIds, int organizationId)
        {
            var OrganizationUserITems = new List<OrganizationUser>();

            usersIds.ToList().ForEach(userId =>
            {
                OrganizationUserITems.Add(new OrganizationUser
                {
                    OrganizationId = organizationId,
                    UserId = userId,
                    Status = EDB_ItemStatus.Active,
                    UserStatus = EDB_UserStatus.Offline
                });
            });


            await intializeDatabase.CreateOrganizationUser.Handler(OrganizationUserITems);
        }
    }
}
