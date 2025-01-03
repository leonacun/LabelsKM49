using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintunitstate
{
    public decimal PausId { get; set; }

    public decimal PausPaintunitId { get; set; }

    public decimal? PausUnloadingentryId { get; set; }

    public DateTime PausTcreation { get; set; }

    public DateTime PausTupdate { get; set; }

    public virtual ICollection<JPaintunitstateelem> JPaintunitstateelems { get; set; } = new List<JPaintunitstateelem>();

    public virtual JPaintunit PausPaintunit { get; set; } = null!;

    public virtual JPaintplanentry? PausUnloadingentry { get; set; }
}
