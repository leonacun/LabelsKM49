using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPackingmaterial
{
    public decimal PmId { get; set; }

    public decimal PmContainerId { get; set; }

    public decimal PmSubjectId { get; set; }

    public DateTime PmTcreation { get; set; }

    public DateTime PmTupdate { get; set; }

    public decimal PmAmount { get; set; }

    public virtual JContainer PmContainer { get; set; } = null!;

    public virtual JSubject PmSubject { get; set; } = null!;
}
