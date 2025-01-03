using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdstatset
{
    public decimal PstsId { get; set; }

    public decimal PstsCompanyId { get; set; }

    public DateTime PstsTcreation { get; set; }

    public DateTime PstsTupdate { get; set; }

    public string PstsKey { get; set; } = null!;

    public string PstsDescr { get; set; } = null!;

    public virtual ICollection<JProdstat> JProdstats { get; set; } = new List<JProdstat>();

    public virtual JCompany PstsCompany { get; set; } = null!;
}
