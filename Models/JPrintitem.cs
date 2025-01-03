using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPrintitem
{
    public decimal PriiId { get; set; }

    public DateTime PriiTcreation { get; set; }

    public DateTime PriiTupdate { get; set; }

    public string PriiKey { get; set; } = null!;

    public string PriiDescr { get; set; } = null!;

    public bool PriiAnonymous { get; set; }

    public string PriiProtocol { get; set; } = null!;

    public decimal? PriiPrinterclassId { get; set; }

    public virtual ICollection<JDoccfgitem> JDoccfgitems { get; set; } = new List<JDoccfgitem>();

    public virtual ICollection<JDocdef> JDocdefs { get; set; } = new List<JDocdef>();

    public virtual ICollection<JPrintcfg> JPrintcfgs { get; set; } = new List<JPrintcfg>();

    public virtual JPrinterclass? PriiPrinterclass { get; set; }
}
