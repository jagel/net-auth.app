using Common.Domain.EntityBase.EntityBaseModel;
using System.Collections.Generic;

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

        public virtual Catalog Catalog { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
