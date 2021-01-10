using domain.Entities.Bases;
using System.Collections.Generic;

namespace pos.Core.Domain.Entities
{
    public class Organization : BaseEntityDescriptive
    {
        public Organization()
        {
            OrganizationChilds = new HashSet<Organization>();
            OrganizationUsers = new HashSet<OrganizationUser>();
            ProductPrices = new HashSet<ProductPrice>();
            Stocks = new HashSet<Stock>();
        }
        public bool IsPrimary { get; set; }
        public int? OrganizationParentId { get; set; }

        public virtual Organization OrganizationParent { get; set; }

        public virtual IEnumerable<Organization> OrganizationChilds { get; set; }
        public virtual IEnumerable<OrganizationUser> OrganizationUsers { get; set; }
        public virtual IEnumerable<ProductPrice> ProductPrices { get; set; }
        public virtual IEnumerable<Stock> Stocks { get; set; }
    }
}
