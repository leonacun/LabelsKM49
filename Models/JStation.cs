using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStation
{
    public decimal StatId { get; set; }

    public decimal StatServerId { get; set; }

    public decimal? StatProdunitId { get; set; }

    public decimal? StatProdunitclassId { get; set; }

    public decimal? StatQualificationclassId { get; set; }

    public decimal? StatLogId { get; set; }

    public DateTime StatTcreation { get; set; }

    public DateTime StatTupdate { get; set; }

    public string StatKey { get; set; } = null!;

    public string StatName { get; set; } = null!;

    public string? StatWorkplaceid { get; set; }

    public string? StatDescr { get; set; }

    public string StatLogintype { get; set; } = null!;

    public string StatPrintpolicy { get; set; } = null!;

    public bool? StatEnabled { get; set; }

    public decimal? StatGroupId { get; set; }

    public string? StatComment { get; set; }

    public bool? StatLogenabled { get; set; }

    public string StatAccesspolicy { get; set; } = null!;

    public decimal? StatTanticketsetId { get; set; }

    public string StatDebugpolicy { get; set; } = null!;

    public string? StatDebugargs { get; set; }

    public DateTime? StatDebuguntiltime { get; set; }

    public decimal? StatUseridentpolicyId { get; set; }

    public virtual ICollection<JService> JServices { get; set; } = new List<JService>();

    public virtual JGroup? StatGroup { get; set; }

    public virtual JLog? StatLog { get; set; }

    public virtual JProdunit? StatProdunit { get; set; }

    public virtual JProdunitclass? StatProdunitclass { get; set; }

    public virtual JQualificationclass? StatQualificationclass { get; set; }

    public virtual JServer StatServer { get; set; } = null!;

    public virtual JTicketset? StatTanticketset { get; set; }

    public virtual JUseridentpolicy? StatUseridentpolicy { get; set; }
}
