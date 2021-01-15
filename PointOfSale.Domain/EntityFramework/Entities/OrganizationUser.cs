using Common.Domain.Definitions;
using Common.Domain.EntityBase.Enitties;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class OrganizationUser : EntityBaseBasic
    {
        public EDB_UserStatus UserStatus { get; set; }

        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}