using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSupply
{
    public decimal SuId { get; set; }

    public decimal SuCompanyId { get; set; }

    public decimal? SuDoccfgId { get; set; }

    public DateTime SuTcreation { get; set; }

    public string SuTransporttype { get; set; } = null!;

    public virtual ICollection<JSupplyentry> JSupplyentries { get; set; } = new List<JSupplyentry>();

    public virtual JCompany SuCompany { get; set; } = null!;

    public virtual JDoccfg? SuDoccfg { get; set; }
}
