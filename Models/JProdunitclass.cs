using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitclass
{
    public decimal PuclId { get; set; }

    public decimal PuclCompanyId { get; set; }

    public DateTime PuclTcreation { get; set; }

    public DateTime PuclTupdate { get; set; }

    public string PuclKey { get; set; } = null!;

    public string PuclDescr { get; set; } = null!;

    public virtual ICollection<JMaintdef> JMaintdefs { get; set; } = new List<JMaintdef>();

    public virtual ICollection<JProdunitclassmember> JProdunitclassmembers { get; set; } = new List<JProdunitclassmember>();

    public virtual ICollection<JStation> JStations { get; set; } = new List<JStation>();

    public virtual JCompany PuclCompany { get; set; } = null!;
}
