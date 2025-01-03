using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTourtemplateinfo
{
    public decimal TteiId { get; set; }

    public decimal TteiTourtemplateId { get; set; }

    public DateTime TteiTcreation { get; set; }

    public DateTime TteiTupdate { get; set; }

    public string TteiType { get; set; } = null!;

    public string? TteiKey { get; set; }

    public DateTime? TteiTimevalue { get; set; }

    public string? TteiStringvalue { get; set; }

    public virtual JTourtemplate TteiTourtemplate { get; set; } = null!;
}
