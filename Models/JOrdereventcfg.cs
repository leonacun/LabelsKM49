using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrdereventcfg
{
    public decimal OevcId { get; set; }

    public decimal OevcContractId { get; set; }

    public decimal? OevcOrdermgrId { get; set; }

    public DateTime OevcTcreation { get; set; }

    public DateTime OevcTupdate { get; set; }

    public string? OevcKey { get; set; }

    public string OevcName { get; set; } = null!;

    public string? OevcDescr { get; set; }

    public string OevcCategory { get; set; } = null!;

    public string OevcOrdertype { get; set; } = null!;

    public string OevcOrderentryselectiontype { get; set; } = null!;

    public string? OevcOrderentrygrouprx { get; set; }

    public bool? OevcPreselectorderentries { get; set; }

    public string? OevcConfiguration { get; set; }

    public string? OevcMode { get; set; }

    public bool? OevcIsinternal { get; set; }

    public string OevcOrdertransformtype { get; set; } = null!;

    public decimal? OevcTolocationclassId { get; set; }

    public virtual ICollection<JOrdereventparam> JOrdereventparams { get; set; } = new List<JOrdereventparam>();

    public virtual ICollection<JToureventcfgcontract> JToureventcfgcontracts { get; set; } = new List<JToureventcfgcontract>();

    public virtual JContract OevcContract { get; set; } = null!;

    public virtual JOrdermgr? OevcOrdermgr { get; set; }

    public virtual JLocationclass? OevcTolocationclass { get; set; }
}
