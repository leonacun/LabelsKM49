using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProduniteventdatum
{
    public decimal PuedId { get; set; }

    public decimal PuedProduniteventId { get; set; }

    public decimal? PuedFailurereasonId { get; set; }

    public decimal? PuedProdtoolId { get; set; }

    public DateTime PuedTcreation { get; set; }

    public string? PuedKey { get; set; }

    public string? PuedValue { get; set; }

    public decimal? PuedFreasongroupId { get; set; }

    public virtual JFailurereason? PuedFailurereason { get; set; }

    public virtual JFreasongroup? PuedFreasongroup { get; set; }

    public virtual JProdtool? PuedProdtool { get; set; }

    public virtual JProdunitevent PuedProdunitevent { get; set; } = null!;
}
