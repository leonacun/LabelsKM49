using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdtoolset
{
    public decimal PtsId { get; set; }

    public decimal PtsCompanyId { get; set; }

    public DateTime PtsTcreation { get; set; }

    public DateTime PtsTupdate { get; set; }

    public string PtsKey { get; set; } = null!;

    public string PtsDescr { get; set; } = null!;

    public virtual ICollection<JProdtool> JProdtools { get; set; } = new List<JProdtool>();

    public virtual JCompany PtsCompany { get; set; } = null!;
}
