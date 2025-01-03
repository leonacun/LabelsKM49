using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JToureventcfg
{
    public decimal TevcId { get; set; }

    public decimal TevcToursetId { get; set; }

    public DateTime TevcTcreation { get; set; }

    public DateTime TevcTupdate { get; set; }

    public string TevcKey { get; set; } = null!;

    public string TevcDescr { get; set; } = null!;

    public decimal? TevcTourtemplateId { get; set; }

    public string TevcCategory { get; set; } = null!;

    public virtual ICollection<JToureventcfgcontract> JToureventcfgcontracts { get; set; } = new List<JToureventcfgcontract>();

    public virtual ICollection<JToureventcfgparam> JToureventcfgparams { get; set; } = new List<JToureventcfgparam>();

    public virtual JTourset TevcTourset { get; set; } = null!;

    public virtual JTourtemplate? TevcTourtemplate { get; set; }
}
