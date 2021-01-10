using domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.Core.Domain.Entities
{
    public class CatalogItem : BaseEntityAudit
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
