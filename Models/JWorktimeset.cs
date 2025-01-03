using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JWorktimeset
{
    public decimal WtsId { get; set; }

    public decimal WtsCompanyId { get; set; }

    public DateTime WtsTcreation { get; set; }

    public DateTime WtsTupdate { get; set; }

    public string WtsKey { get; set; } = null!;

    public string WtsDescr { get; set; } = null!;

    public virtual ICollection<JWorktime> JWorktimes { get; set; } = new List<JWorktime>();

    public virtual JCompany WtsCompany { get; set; } = null!;
}
