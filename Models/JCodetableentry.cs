using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCodetableentry
{
    public decimal CoteId { get; set; }

    public decimal CoteCodetableId { get; set; }

    public DateTime CoteTcreation { get; set; }

    public DateTime CoteTupdate { get; set; }

    public string? CoteKey { get; set; }

    public string CoteCode { get; set; } = null!;

    public string? CoteValue { get; set; }

    public string? CoteDescr { get; set; }

    public virtual JCodetable CoteCodetable { get; set; } = null!;

    public virtual ICollection<JCalendarentry> JCalendarentries { get; set; } = new List<JCalendarentry>();

    public virtual ICollection<JStockevent> JStockevents { get; set; } = new List<JStockevent>();
}
