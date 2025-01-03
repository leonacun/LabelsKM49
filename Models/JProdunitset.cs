using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitset
{
    public decimal PusId { get; set; }

    public decimal PusCompanyId { get; set; }

    public DateTime PusTcreation { get; set; }

    public DateTime PusTupdate { get; set; }

    public string PusKey { get; set; } = null!;

    public string PusDescr { get; set; } = null!;

    public virtual ICollection<JProdunit> JProdunits { get; set; } = new List<JProdunit>();

    public virtual JCompany PusCompany { get; set; } = null!;
}
