using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JErpentitytype
{
    public decimal EetId { get; set; }

    public decimal EetErpentitytypesetId { get; set; }

    public DateTime EetTcreation { get; set; }

    public DateTime EetTupdate { get; set; }

    public string EetKey { get; set; } = null!;

    public string EetDescr { get; set; } = null!;

    public virtual JErpentitytypeset EetErpentitytypeset { get; set; } = null!;

    public virtual ICollection<JErpentity> JErpentities { get; set; } = new List<JErpentity>();
}
