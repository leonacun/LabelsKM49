using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JToolgroup
{
    public decimal TogId { get; set; }

    public decimal TogCompanyId { get; set; }

    public DateTime TogTcreation { get; set; }

    public DateTime TogTupdate { get; set; }

    public string TogDescr { get; set; } = null!;

    public string? TogKey { get; set; }

    public virtual ICollection<JTool> JTools { get; set; } = new List<JTool>();

    public virtual JCompany TogCompany { get; set; } = null!;
}
