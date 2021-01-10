using domain.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities.Interfaces
{
    public interface IBaseEntityDescriptive
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EDB_ItemStatus Status { get; set; }
    }
}
