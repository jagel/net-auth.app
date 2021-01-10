using domain.Entities.Bases;
using System.Collections.Generic;

namespace pos.Core.Domain.Entities
{
    public class Stock : BaseEntityAudit
    {
        public int Amount { get; set; }

        public int OrganizationId { get; set; }
        public int ProductId { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Product Product { get; set; }
    }
}
