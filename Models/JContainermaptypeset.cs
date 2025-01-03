using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainermaptypeset
{
    public decimal CtmtsId { get; set; }

    public decimal CtmtsCompanyId { get; set; }

    public DateTime CtmtsTcreation { get; set; }

    public DateTime CtmtsTupdate { get; set; }

    public string CtmtsKey { get; set; } = null!;

    public string CtmtsDescr { get; set; } = null!;

    public virtual JCompany CtmtsCompany { get; set; } = null!;

    public virtual ICollection<JContainermaptype> JContainermaptypes { get; set; } = new List<JContainermaptype>();
}
