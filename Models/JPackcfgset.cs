using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPackcfgset
{
    public decimal PcfsId { get; set; }

    public decimal PcfsCompanyId { get; set; }

    public DateTime PcfsTcreation { get; set; }

    public DateTime PcfsTupdate { get; set; }

    public string PcfsKey { get; set; } = null!;

    public string PcfsDescr { get; set; } = null!;

    public virtual ICollection<JPackcfg> JPackcfgs { get; set; } = new List<JPackcfg>();

    public virtual JCompany PcfsCompany { get; set; } = null!;
}
