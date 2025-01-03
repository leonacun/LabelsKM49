using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrdereventparam
{
    public decimal OevpId { get; set; }

    public decimal OevpOrdereventcfgId { get; set; }

    public DateTime OevpTcreation { get; set; }

    public DateTime OevpTupdate { get; set; }

    public string OevpName { get; set; } = null!;

    public string? OevpDescr { get; set; }

    public string OevpType { get; set; } = null!;

    public bool OevpIsmandatory { get; set; }

    public string? OevpSelector { get; set; }

    public string? OevpDefaultvalue { get; set; }

    public bool? OevpIsconstant { get; set; }

    public virtual JOrdereventcfg OevpOrdereventcfg { get; set; } = null!;
}
