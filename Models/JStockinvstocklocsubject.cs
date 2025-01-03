using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvstocklocsubject
{
    public decimal StislsId { get; set; }

    public decimal StislsStockinvstocklocId { get; set; }

    public decimal StislsSubjectId { get; set; }

    public DateTime StislsTcreation { get; set; }

    public DateTime StislsTupdate { get; set; }

    public decimal StislsAmount { get; set; }

    public int StislsCountidx { get; set; }

    public virtual JStockinvstockloc StislsStockinvstockloc { get; set; } = null!;

    public virtual JSubject StislsSubject { get; set; } = null!;
}
