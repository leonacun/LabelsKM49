using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockchannel
{
    public decimal StchId { get; set; }

    public decimal StchStockId { get; set; }

    public decimal? StchOtherstockId { get; set; }

    public decimal? StchContainersetclassId { get; set; }

    public decimal? StchSubjectclassId { get; set; }

    public DateTime StchTcreation { get; set; }

    public DateTime StchTupdate { get; set; }

    public string StchDirection { get; set; } = null!;

    public string? StchDescr { get; set; }

    public string StchCode { get; set; } = null!;

    public bool StchAllowsubjects { get; set; }

    public bool StchAllowcontainers { get; set; }

    public bool StchAllowparts { get; set; }

    public decimal? StchContainermaptypeId { get; set; }

    public decimal? StchOtherstockclassId { get; set; }

    public virtual JContainermaptype? StchContainermaptype { get; set; }

    public virtual JContainersetclass? StchContainersetclass { get; set; }

    public virtual JStock? StchOtherstock { get; set; }

    public virtual JStockclass? StchOtherstockclass { get; set; }

    public virtual JStock StchStock { get; set; } = null!;

    public virtual JSubjectclass? StchSubjectclass { get; set; }
}
