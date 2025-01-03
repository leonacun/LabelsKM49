using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JToureventcfgcontract
{
    public decimal TevccId { get; set; }

    public decimal TevccToureventcfgId { get; set; }

    public decimal TevccContractId { get; set; }

    public decimal TevccOrdereventcfgId { get; set; }

    public DateTime TevccTcreation { get; set; }

    public virtual JContract TevccContract { get; set; } = null!;

    public virtual JOrdereventcfg TevccOrdereventcfg { get; set; } = null!;

    public virtual JToureventcfg TevccToureventcfg { get; set; } = null!;
}
