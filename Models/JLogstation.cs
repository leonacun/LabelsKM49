using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogstation
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string StatKey { get; set; } = null!;

    public string StatName { get; set; } = null!;

    public string? StatWorkplaceid { get; set; }

    public string? StatDescr { get; set; }

    public string StatLogintype { get; set; } = null!;

    public string StatPrintpolicy { get; set; } = null!;

    public bool? StatEnabled { get; set; }

    public decimal? StatServerId { get; set; }

    public decimal? StatProdunitId { get; set; }

    public decimal? StatProdunitclassId { get; set; }

    public decimal? StatQualificationclassId { get; set; }

    public decimal? StatLogId { get; set; }

    public decimal? StatGroupId { get; set; }

    public string? StatComment { get; set; }

    public bool? StatLogenabled { get; set; }

    public string StatAccesspolicy { get; set; } = null!;

    public decimal? StatTanticketsetId { get; set; }

    public string StatDebugpolicy { get; set; } = null!;

    public string? StatDebugargs { get; set; }

    public DateTime? StatDebuguntiltime { get; set; }

    public decimal? StatUseridentpolicyId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
