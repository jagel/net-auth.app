using domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.Core.Domain.Entities
{
    public class PurchaseSummary : BaseEntitySingle
    {
        public PurchaseSummary()
        {
            PurchaseProducts = new HashSet<PurchaseProduct>();
        }
        public decimal Discount { get; set; }
        public int TotalProducts { get; set; }
        public int Total { get; set; }
        public DateTime PurchaseDate { get; set; }

        public IEnumerable<PurchaseProduct> PurchaseProducts { get; set; }
    }
}
