using domain.Entities;
using domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.Core.Domain.Entities
{
    public class OrganizationUser : BaseEntitySingle
    {
        public EDB_UserStatus UserStatus { get; set; }
        public int OrganizationId { get; set; }
        public int UserId { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
    }
}