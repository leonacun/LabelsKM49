using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAdviceinfo
{
    public decimal AdviId { get; set; }

    public decimal AdviAdviceId { get; set; }

    public decimal? AdviImageId { get; set; }

    public DateTime AdviTcreation { get; set; }

    public DateTime AdviTupdate { get; set; }

    public string AdviType { get; set; } = null!;

    public string? AdviKey1 { get; set; }

    public string? AdviKey2 { get; set; }

    public string? AdviKey3 { get; set; }

    public DateTime? AdviTimevalue { get; set; }

    public string? AdviStringvalue { get; set; }

    public int? AdviIntvalue { get; set; }

    public virtual JAdvice AdviAdvice { get; set; } = null!;

    public virtual JImage? AdviImage { get; set; }
}
