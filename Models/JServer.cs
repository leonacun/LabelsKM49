using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JServer
{
    public decimal SerId { get; set; }

    public DateTime SerTcreation { get; set; }

    public DateTime SerTupdate { get; set; }

    public string SerKey { get; set; } = null!;

    public string SerDescr { get; set; } = null!;

    public decimal? SerLogId { get; set; }

    public bool? SerLogenabled { get; set; }

    public decimal? SerUseridentpolicyId { get; set; }

    public virtual ICollection<JServerlog> JServerlogs { get; set; } = new List<JServerlog>();

    public virtual ICollection<JServicedef> JServicedefs { get; set; } = new List<JServicedef>();

    public virtual ICollection<JStation> JStations { get; set; } = new List<JStation>();

    public virtual JLog? SerLog { get; set; }

    public virtual JUseridentpolicy? SerUseridentpolicy { get; set; }
}
