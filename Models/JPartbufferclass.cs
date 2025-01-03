using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPartbufferclass
{
    public decimal PbcId { get; set; }

    public decimal PbcCompanyId { get; set; }

    public DateTime PbcTcreation { get; set; }

    public DateTime PbcTupdate { get; set; }

    public string PbcKey { get; set; } = null!;

    public string PbcDescr { get; set; } = null!;

    public bool PbcUniqueparts { get; set; }

    public virtual ICollection<JPartbufferclassmember> JPartbufferclassmembers { get; set; } = new List<JPartbufferclassmember>();

    public virtual JCompany PbcCompany { get; set; } = null!;
}
