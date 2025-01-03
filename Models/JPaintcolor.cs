using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintcolor
{
    public decimal PacId { get; set; }

    public decimal PacColorId { get; set; }

    public decimal PacPaintunitId { get; set; }

    public DateTime PacTcreation { get; set; }

    public DateTime PacTupdate { get; set; }

    public bool PacLocked { get; set; }

    public string? PacInfo1 { get; set; }

    public string? PacInfo2 { get; set; }

    public string? PacInfo3 { get; set; }

    public virtual ICollection<JPaintcolorinfo> JPaintcolorinfos { get; set; } = new List<JPaintcolorinfo>();

    public virtual JColor PacColor { get; set; } = null!;

    public virtual JPaintunit PacPaintunit { get; set; } = null!;
}
