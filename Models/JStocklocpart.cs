using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocklocpart
{
    public decimal StlpId { get; set; }

    public decimal StlpStocklocId { get; set; }

    public decimal StlpSubjectId { get; set; }

    public decimal StlpPartId { get; set; }

    public DateTime StlpTcreation { get; set; }

    public DateTime StlpTupdate { get; set; }

    public virtual JPart StlpPart { get; set; } = null!;

    public virtual JStockloc StlpStockloc { get; set; } = null!;

    public virtual JSubject StlpSubject { get; set; } = null!;
}
