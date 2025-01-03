using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLock
{
    public decimal LockId { get; set; }

    public decimal LockCompanyId { get; set; }

    public DateTime LockTcreation { get; set; }

    public string LockKey { get; set; } = null!;

    public string LockDescr { get; set; } = null!;

    public string? LockOwnername { get; set; }

    public string? LockOwnerprocessid { get; set; }

    public DateTime? LockLockexpectedtime { get; set; }

    public short LockLockexpectedtimeoutinsec { get; set; }

    public virtual JCompany LockCompany { get; set; } = null!;
}
