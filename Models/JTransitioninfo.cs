using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransitioninfo
{
    public decimal TrsiId { get; set; }

    public decimal TrsiTransitionId { get; set; }

    public DateTime TrsiTcreation { get; set; }

    public string TrsiValuetype { get; set; } = null!;

    public string? TrsiKey1 { get; set; }

    public string? TrsiKey2 { get; set; }

    public string? TrsiKey3 { get; set; }

    public decimal? TrsiObjectid { get; set; }

    public string? TrsiObjectclassname { get; set; }

    public string? TrsiObjectinfo1 { get; set; }

    public string? TrsiObjectinfo2 { get; set; }

    public string? TrsiStringvalue { get; set; }

    public virtual JTransition TrsiTransition { get; set; } = null!;
}
