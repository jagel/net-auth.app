using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain.Definitions
{
    public enum EDB_ItemStatus
    {
        Active = 0,
        Deactive = 1,
        PendingApproval = 2,
        PendingToDelete = 3
    }

    public enum EDB_UserStatus
    {
        Offline = 0,
        Online = 1,
        Busy = 2,
        Away = 3,
        NotDisturb = 4
    }

    public enum EDB_CatalogDisplay
    {
        Alphabet_Asc,
        Alphabet_Desc,
        Manual
    }
}
