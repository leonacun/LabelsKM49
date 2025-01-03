using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JGroupmember
{
    public decimal GmId { get; set; }

    public decimal GmGroupId { get; set; }

    public decimal GmUserId { get; set; }

    public DateTime GmTcreation { get; set; }

    public virtual JGroup GmGroup { get; set; } = null!;

    public virtual JUser GmUser { get; set; } = null!;
}
