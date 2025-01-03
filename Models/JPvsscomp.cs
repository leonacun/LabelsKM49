using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvsscomp
{
    public decimal PvcId { get; set; }

    public decimal PvcPvsssubjectId { get; set; }

    public DateTime PvcTcreation { get; set; }

    public DateTime PvcTupdate { get; set; }

    public string PvcName { get; set; } = null!;

    public virtual JPvsssubject PvcPvsssubject { get; set; } = null!;
}
