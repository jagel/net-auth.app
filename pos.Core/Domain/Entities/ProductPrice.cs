using domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.Core.Domain.Entities
{
    public class ProductPrice : BaseEntityAudit
    {
        public decimal UnitPrice { get; set; }
        public bool IsCurrentPrice { get; set; }

        public int OrganizationId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Organization Organization { get; set; }
    }
}