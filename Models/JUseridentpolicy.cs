using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUseridentpolicy
{
    public decimal UidpId { get; set; }

    public decimal UidpCompanyId { get; set; }

    public DateTime UidpTcreation { get; set; }

    public DateTime UidpTupdate { get; set; }

    public string UidpKey { get; set; } = null!;

    public string UidpDescr { get; set; } = null!;

    public bool UidpByshortname { get; set; }

    public bool UidpByno { get; set; }

    public bool UidpBycardid { get; set; }

    public virtual ICollection<JServer> JServers { get; set; } = new List<JServer>();

    public virtual ICollection<JStation> JStations { get; set; } = new List<JStation>();

    public virtual JCompany UidpCompany { get; set; } = null!;
}
