using domain.Entities.Bases;
using System.Collections.Generic;

namespace pos.Core.Domain.Entities
{
    public class User : BaseEntityAudit
    {
        public User()
        {
            OrganizationUsers = new HashSet<OrganizationUser>();
        }
        public string UserName { get; set; }
        public string Token { get; set; }
        public string Pasword { get; set; }
        public string Email { get; set; }

        public virtual IEnumerable<OrganizationUser> OrganizationUsers { get; set; }
    }
}
