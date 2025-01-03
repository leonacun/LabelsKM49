using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdnote
{
    public decimal PnId { get; set; }

    public decimal PnProdnotesetId { get; set; }

    public decimal? PnProdunitId { get; set; }

    public DateTime PnTcreation { get; set; }

    public DateTime PnTupdate { get; set; }

    public string PnNo { get; set; } = null!;

    public string? PnDescr { get; set; }

    public bool PnOpen { get; set; }

    public decimal? PnProdjobId { get; set; }

    public virtual ICollection<JProdnoteentry> JProdnoteentries { get; set; } = new List<JProdnoteentry>();

    public virtual JProdjob? PnProdjob { get; set; }

    public virtual JProdnoteset PnProdnoteset { get; set; } = null!;

    public virtual JProdunit? PnProdunit { get; set; }
}
