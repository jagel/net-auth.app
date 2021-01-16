using Common.Domain.EntityBase.Enitties;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class Purchase : EntityBaseBasic
    {
        public Purchase()
        {
            PurchaseProducts = new HashSet<PurchaseProduct>();
        }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public DateTime PurchaseDate { get; set; }

        public int UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<PurchaseProduct> PurchaseProducts { get; set; }
    }
}
