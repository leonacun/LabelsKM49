using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitinterval
{
    public decimal PuivId { get; set; }

    public decimal? PuivProdunitId { get; set; }

    public decimal? PuivFailurereasonId { get; set; }

    public DateTime PuivTcreation { get; set; }

    public DateTime PuivTupdate { get; set; }

    public string PuivType { get; set; } = null!;

    public DateTime PuivFromtime { get; set; }

    public DateTime? PuivUntiltime { get; set; }

    public string? PuivComment { get; set; }

    public string? PuivQualifier1 { get; set; }

    public virtual ICollection<JProdunitintervalinfo> JProdunitintervalinfos { get; set; } = new List<JProdunitintervalinfo>();

    public virtual JFailurereason? PuivFailurereason { get; set; }

    public virtual JProdunit? PuivProdunit { get; set; }
}
