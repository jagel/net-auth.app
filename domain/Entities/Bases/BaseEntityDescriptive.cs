using domain.Application;
using domain.Entities.Interfaces;
using System;

namespace domain.Entities.Bases
{
    public class BaseEntityDescriptive : IBaseEntityDescriptive
    {
       public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EDB_ItemStatus Status { get; set; }
    }
}
