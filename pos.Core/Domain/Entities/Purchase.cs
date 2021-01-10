using domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.Core.Domain.Entities
{
    public class Purchase : BaseEntitySingle
    {
        public Purchase()
        {
            PurchaseProducts = new HashSet<PurchaseProduct>();
        }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public DateTime PurchaseDate { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public IEnumerable<PurchaseProduct> PurchaseProducts { get; set; }
    }
}
