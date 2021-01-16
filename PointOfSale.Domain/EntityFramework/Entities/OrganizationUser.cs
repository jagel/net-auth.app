using Common.Domain.Definitions;
using Common.Domain.EntityBase.Enitties;
using System.Text.Json.Serialization;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class OrganizationUser : EntityBaseBasic
    {
        public OrganizationUser()
        {

        }

        public EDB_UserStatus UserStatus { get; set; }

        public int OrganizationId { get; set; }
        public int UserId { get; set; }
        
        
        [JsonIgnore]
        public virtual Organization Organization { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
    }
}