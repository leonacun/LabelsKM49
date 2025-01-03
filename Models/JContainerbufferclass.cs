using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerbufferclass
{
    public decimal CtbcId { get; set; }

    public decimal CtbcCompanyId { get; set; }

    public DateTime CtbcTcreation { get; set; }

    public DateTime CtbcTupdate { get; set; }

    public string CtbcKey { get; set; } = null!;

    public string CtbcDescr { get; set; } = null!;

    public bool CtbcUniquecontainers { get; set; }

    public virtual JCompany CtbcCompany { get; set; } = null!;

    public virtual ICollection<JContainerbufferclassm> JContainerbufferclassms { get; set; } = new List<JContainerbufferclassm>();
}
