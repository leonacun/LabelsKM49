using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoginpolicyitem
{
    public decimal LpiId { get; set; }

    public decimal LpiLoginpolicyId { get; set; }

    public decimal? LpiUsersetId { get; set; }

    public decimal? LpiUserId { get; set; }

    public DateTime LpiTcreation { get; set; }

    public DateTime LpiTupdate { get; set; }

    public string LpiType { get; set; } = null!;

    public string LpiKey { get; set; } = null!;

    public string LpiStringvalue { get; set; } = null!;

    public decimal? LpiCodetableId { get; set; }

    public virtual JCodetable? LpiCodetable { get; set; }

    public virtual JLoginpolicy LpiLoginpolicy { get; set; } = null!;

    public virtual JUser? LpiUser { get; set; }

    public virtual JUserset? LpiUserset { get; set; }
}
