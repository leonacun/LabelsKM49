using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdreplenishmentcfgset
{
    public decimal PrcfsId { get; set; }

    public decimal PrcfsCompanyId { get; set; }

    public DateTime PrcfsTcreation { get; set; }

    public DateTime PrcfsTupdate { get; set; }

    public string PrcfsKey { get; set; } = null!;

    public string PrcfsDescr { get; set; } = null!;

    public virtual ICollection<JProdreplenishmentcfg> JProdreplenishmentcfgs { get; set; } = new List<JProdreplenishmentcfg>();

    public virtual JCompany PrcfsCompany { get; set; } = null!;
}
