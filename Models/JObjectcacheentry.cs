using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JObjectcacheentry
{
    public decimal OcaeId { get; set; }

    public decimal OcaeObjectcacheId { get; set; }

    public DateTime OcaeTcreation { get; set; }

    public decimal OcaeObjectid { get; set; }

    public virtual JObjectcache OcaeObjectcache { get; set; } = null!;
}
