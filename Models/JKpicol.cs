using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JKpicol
{
    public decimal KpicId { get; set; }

    public decimal KpicKpiId { get; set; }

    public DateTime KpicTcreation { get; set; }

    public DateTime KpicTupdate { get; set; }

    public byte KpicIndex { get; set; }

    public string KpicDescr { get; set; } = null!;

    public string KpicLabel { get; set; } = null!;

    public string KpicValuetype { get; set; } = null!;

    public virtual ICollection<JKpivalue> JKpivalues { get; set; } = new List<JKpivalue>();

    public virtual JKpi KpicKpi { get; set; } = null!;
}
