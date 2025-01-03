using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobbufferclass
{
    public decimal PjbcId { get; set; }

    public decimal PjbcCompanyId { get; set; }

    public DateTime PjbcTcreation { get; set; }

    public DateTime PjbcTupdate { get; set; }

    public string PjbcKey { get; set; } = null!;

    public string PjbcDescr { get; set; } = null!;

    public bool PjbcUniqueprodjobs { get; set; }

    public virtual ICollection<JProdjobbufferclassm> JProdjobbufferclassms { get; set; } = new List<JProdjobbufferclassm>();

    public virtual JCompany PjbcCompany { get; set; } = null!;
}
