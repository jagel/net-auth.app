using domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.Core.Domain.Entities
{
    public class Product : BaseEntityDescriptive
    {
        public Product()
        {
            ProductPrices = new HashSet<ProductPrice>();
        }
        public string Barcode { get; set; }
        public string Reference { get; set; }

        public int BrandId { get; set; }

        public virtual CatalogItem Brand { get; set; }

        public virtual IEnumerable<ProductPrice> ProductPrices { get; set; }
    }
}
