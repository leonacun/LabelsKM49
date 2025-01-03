using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JToureventcfgparam
{
    public decimal TevcpId { get; set; }

    public decimal TevcpToureventcfgId { get; set; }

    public DateTime TevcpTcreation { get; set; }

    public DateTime TevcpTupdate { get; set; }

    public string TevcpName { get; set; } = null!;

    public string? TevcpDescr { get; set; }

    public bool TevcpIseditable { get; set; }

    public string? TevcpDefaultvalue { get; set; }

    public virtual JToureventcfg TevcpToureventcfg { get; set; } = null!;
}
