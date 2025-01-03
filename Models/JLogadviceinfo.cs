using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogadviceinfo
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string AdviType { get; set; } = null!;

    public string? AdviKey1 { get; set; }

    public string? AdviKey2 { get; set; }

    public string? AdviKey3 { get; set; }

    public DateTime? AdviTimevalue { get; set; }

    public string? AdviStringvalue { get; set; }

    public int? AdviIntvalue { get; set; }

    public decimal? AdviAdviceId { get; set; }

    public decimal? AdviImageId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
