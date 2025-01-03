using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidinfoinfo
{
    public decimal SkiiId { get; set; }

    public decimal SkiiSkidinfoId { get; set; }

    public DateTime SkiiTcreation { get; set; }

    public DateTime SkiiTupdate { get; set; }

    public string SkiiType { get; set; } = null!;

    public string? SkiiKey1 { get; set; }

    public string? SkiiKey2 { get; set; }

    public string? SkiiKey3 { get; set; }

    public DateTime? SkiiTimevalue { get; set; }

    public string? SkiiStringvalue { get; set; }

    public int? SkiiIntvalue { get; set; }

    public virtual JSkidinfo SkiiSkidinfo { get; set; } = null!;
}
