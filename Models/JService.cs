using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JService
{
    public decimal SvcId { get; set; }

    public decimal SvcServicedefId { get; set; }

    public decimal SvcStationId { get; set; }

    public DateTime SvcTcreation { get; set; }

    public DateTime SvcTupdate { get; set; }

    public bool? SvcEnabled { get; set; }

    public virtual ICollection<JServicepropertyset> JServicepropertysets { get; set; } = new List<JServicepropertyset>();

    public virtual JServicedef SvcServicedef { get; set; } = null!;

    public virtual JStation SvcStation { get; set; } = null!;
}
