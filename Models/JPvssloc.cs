using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvssloc
{
    public decimal PvlId { get; set; }

    public decimal PvlPvssId { get; set; }

    public decimal? PvlPvsssubjectId { get; set; }

    public decimal PvlPvssareaId { get; set; }

    public DateTime PvlTcreation { get; set; }

    public DateTime PvlTupdate { get; set; }

    public string PvlCode { get; set; } = null!;

    public virtual JPvss PvlPvss { get; set; } = null!;

    public virtual JPvssarea PvlPvssarea { get; set; } = null!;

    public virtual JPvsssubject? PvlPvsssubject { get; set; }
}
