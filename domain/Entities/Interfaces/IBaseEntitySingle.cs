using domain.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities.Interfaces
{
    public interface IBaseEntitySingle
    {
        public int Id { get; set; }
        public EDB_ItemStatus Status { get; set; }
    }
}
