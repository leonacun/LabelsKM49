using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintcolorinfo
{
    public decimal PaciId { get; set; }

    public decimal PaciPaintcolorId { get; set; }

    public DateTime PaciTcreation { get; set; }

    public DateTime PaciTupdate { get; set; }

    public string PaciType { get; set; } = null!;

    public string? PaciKey1 { get; set; }

    public string? PaciKey2 { get; set; }

    public string? PaciKey3 { get; set; }

    public DateTime? PaciTimevalue { get; set; }

    public string? PaciStringvalue { get; set; }

    public virtual JPaintcolor PaciPaintcolor { get; set; } = null!;
}
