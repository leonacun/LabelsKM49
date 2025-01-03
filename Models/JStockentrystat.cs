using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockentrystat
{
    public decimal SesId { get; set; }

    public decimal SesStockId { get; set; }

    public decimal SesSubjectId { get; set; }

    public DateTime SesTcreation { get; set; }

    public DateTime SesTupdate { get; set; }

    public decimal SesMinamount { get; set; }

    public decimal SesMaxamount { get; set; }

    public short SesSubstcount { get; set; }

    public string SesUpdatestrategy { get; set; } = null!;

    public virtual ICollection<JStockentrydyn> JStockentrydyns { get; set; } = new List<JStockentrydyn>();

    public virtual ICollection<JStockentrymark> JStockentrymarks { get; set; } = new List<JStockentrymark>();

    public virtual ICollection<JStockentrysubst> JStockentrysubstSesuStats { get; set; } = new List<JStockentrysubst>();

    public virtual ICollection<JStockentrysubst> JStockentrysubstSesuSubststats { get; set; } = new List<JStockentrysubst>();

    public virtual ICollection<JStockevent> JStockevents { get; set; } = new List<JStockevent>();

    public virtual ICollection<JStockinvstockentry> JStockinvstockentries { get; set; } = new List<JStockinvstockentry>();

    public virtual ICollection<JStockre> JStockres { get; set; } = new List<JStockre>();

    public virtual ICollection<JStocksubstevent> JStocksubsteventSseStockentries { get; set; } = new List<JStocksubstevent>();

    public virtual ICollection<JStocksubstevent> JStocksubsteventSseSubststockentries { get; set; } = new List<JStocksubstevent>();

    public virtual JStock SesStock { get; set; } = null!;

    public virtual JSubject SesSubject { get; set; } = null!;
}
