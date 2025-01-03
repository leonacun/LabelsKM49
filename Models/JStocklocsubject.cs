using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocklocsubject
{
    public decimal StlsId { get; set; }

    public decimal StlsStocklocId { get; set; }

    public decimal StlsSubjectId { get; set; }

    public decimal? StlsOrderentryId { get; set; }

    public DateTime StlsTcreation { get; set; }

    public DateTime StlsTupdate { get; set; }

    public decimal StlsAmount { get; set; }

    public virtual JOrderentry? StlsOrderentry { get; set; }

    public virtual JStockloc StlsStockloc { get; set; } = null!;

    public virtual JSubject StlsSubject { get; set; } = null!;
}
