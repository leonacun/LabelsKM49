using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JColorclass
{
    public decimal ColcId { get; set; }

    public decimal ColcCompanyId { get; set; }

    public DateTime ColcTcreation { get; set; }

    public DateTime ColcTupdate { get; set; }

    public string ColcKey { get; set; } = null!;

    public string ColcDescr { get; set; } = null!;

    public virtual JCompany ColcCompany { get; set; } = null!;

    public virtual ICollection<JColorclassmember> JColorclassmembers { get; set; } = new List<JColorclassmember>();
}
