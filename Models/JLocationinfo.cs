using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLocationinfo
{
    public decimal LiId { get; set; }

    public decimal LiLocationId { get; set; }

    public decimal? LiReflocationId { get; set; }

    public DateTime LiTcreation { get; set; }

    public DateTime LiTupdate { get; set; }

    public string LiType { get; set; } = null!;

    public string? LiKey1 { get; set; }

    public string? LiKey2 { get; set; }

    public string? LiKey3 { get; set; }

    public DateTime? LiTimevalue { get; set; }

    public string? LiStringvalue { get; set; }

    public virtual JLocation LiLocation { get; set; } = null!;

    public virtual JLocation? LiReflocation { get; set; }
}
