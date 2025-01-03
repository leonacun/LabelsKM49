using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkideventset
{
    public decimal SkesId { get; set; }

    public decimal SkesCompanyId { get; set; }

    public DateTime SkesTcreation { get; set; }

    public DateTime SkesTupdate { get; set; }

    public string SkesKey { get; set; } = null!;

    public string SkesDescr { get; set; } = null!;

    public virtual ICollection<JSkidevent> JSkidevents { get; set; } = new List<JSkidevent>();

    public virtual JCompany SkesCompany { get; set; } = null!;
}
