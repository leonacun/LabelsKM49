using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobset
{
    public decimal PjsId { get; set; }

    public decimal PjsCompanyId { get; set; }

    public decimal? PjsCounterId { get; set; }

    public DateTime PjsTcreation { get; set; }

    public DateTime PjsTupdate { get; set; }

    public string PjsKey { get; set; } = null!;

    public string PjsDescr { get; set; } = null!;

    public string? PjsSheettype { get; set; }

    public string? PjsLabeltype { get; set; }

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual JCompany PjsCompany { get; set; } = null!;

    public virtual JCounter? PjsCounter { get; set; }
}
