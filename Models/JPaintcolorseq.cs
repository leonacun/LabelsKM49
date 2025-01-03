using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintcolorseq
{
    public decimal PacsId { get; set; }

    public decimal PacsPaintunitId { get; set; }

    public decimal PacsColorId { get; set; }

    public decimal PacsSucccolorId { get; set; }

    public DateTime PacsTcreation { get; set; }

    public DateTime PacsTupdate { get; set; }

    public bool PacsLocked { get; set; }

    public virtual JColor PacsColor { get; set; } = null!;

    public virtual JPaintunit PacsPaintunit { get; set; } = null!;

    public virtual JColor PacsSucccolor { get; set; } = null!;
}
