using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JErpentitytypeset
{
    public decimal EetsId { get; set; }

    public DateTime EetsTcreation { get; set; }

    public DateTime EetsTupdate { get; set; }

    public string EetsKey { get; set; } = null!;

    public string EetsDescr { get; set; } = null!;

    public virtual ICollection<JErpentitytype> JErpentitytypes { get; set; } = new List<JErpentitytype>();
}
