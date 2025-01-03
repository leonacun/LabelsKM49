using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdnoteset
{
    public decimal PnsId { get; set; }

    public decimal PnsCompanyId { get; set; }

    public decimal? PnsCounterId { get; set; }

    public decimal? PnsDoccfgId { get; set; }

    public DateTime PnsTcreation { get; set; }

    public DateTime PnsTupdate { get; set; }

    public string PnsKey { get; set; } = null!;

    public string PnsDescr { get; set; } = null!;

    public virtual ICollection<JProdnote> JProdnotes { get; set; } = new List<JProdnote>();

    public virtual JCompany PnsCompany { get; set; } = null!;

    public virtual JCounter? PnsCounter { get; set; }

    public virtual JDoccfg? PnsDoccfg { get; set; }
}
