using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvcresult
{
    public decimal SticrId { get; set; }

    public decimal SticrStockinvId { get; set; }

    public DateTime SticrTcreation { get; set; }

    public DateTime SticrTupdate { get; set; }

    public string SticrType { get; set; } = null!;

    public virtual ICollection<JStockinvcresultitem> JStockinvcresultitems { get; set; } = new List<JStockinvcresultitem>();

    public virtual JStockinv SticrStockinv { get; set; } = null!;
}
