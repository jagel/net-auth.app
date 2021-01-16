using Common.Domain.EntityBase.EntityBaseModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class CatalogItem : EntityBaseAudit
    {
        public CatalogItem()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }
        public int? Order { get; set; }
        public string ItemKey { get; set; }

        public int CatalogId { get; set; }

        [JsonIgnore]
        public virtual Catalog Catalog { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
