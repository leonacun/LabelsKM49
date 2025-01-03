using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintdefset
{
    public decimal MadsId { get; set; }

    public decimal MadsCompanyId { get; set; }

    public DateTime MadsTcreation { get; set; }

    public DateTime MadsTupdate { get; set; }

    public string MadsKey { get; set; } = null!;

    public string MadsDescr { get; set; } = null!;

    public virtual ICollection<JMaintdef> JMaintdefs { get; set; } = new List<JMaintdef>();

    public virtual JCompany MadsCompany { get; set; } = null!;
}
