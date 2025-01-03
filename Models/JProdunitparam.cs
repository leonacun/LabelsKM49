using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitparam
{
    public decimal PupId { get; set; }

    public decimal PupProdunitId { get; set; }

    public DateTime PupTcreation { get; set; }

    public DateTime PupTupdate { get; set; }

    public string PupKey { get; set; } = null!;

    public string? PupDescr { get; set; }

    public string? PupValue { get; set; }

    public virtual JProdunit PupProdunit { get; set; } = null!;
}
