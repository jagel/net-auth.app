using Common.Domain.Definitions;
using Common.Domain.EntityBase.Enitties;
using System.Collections.Generic;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class Catalog : EntityBaseDescriptive
    {
        public Catalog()
        {
            CatalogItems = new HashSet<CatalogItem>();
        }

        public EDB_CatalogDisplay OrderDisplay { get; set; }

        public virtual IEnumerable<CatalogItem> CatalogItems { get; set; }

    }
}
