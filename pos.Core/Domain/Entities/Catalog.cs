using domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.Core.Domain.Entities
{
    public class Catalog : BaseEntityDescriptive
    {
        public Catalog()
        {
            CatalogItems = new HashSet<CatalogItem>();
        }

        public int OrderDisplay { get; set; }

        public virtual IEnumerable<CatalogItem> CatalogItems { get; set; }
    }
}
