using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JErpentityset
{
    public decimal EesId { get; set; }

    public DateTime EesTcreation { get; set; }

    public DateTime EesTupdate { get; set; }

    public string EesKey { get; set; } = null!;

    public string EesDescr { get; set; } = null!;

    public virtual ICollection<JErpentity> JErpentities { get; set; } = new List<JErpentity>();
}
