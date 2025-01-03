using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvss
{
    public decimal PvId { get; set; }

    public DateTime PvTcreation { get; set; }

    public DateTime PvTupdate { get; set; }

    public string PvKey { get; set; } = null!;

    public string PvDescr { get; set; } = null!;

    public virtual ICollection<JPvssarea> JPvssareas { get; set; } = new List<JPvssarea>();

    public virtual ICollection<JPvssboxdatum> JPvssboxdata { get; set; } = new List<JPvssboxdatum>();

    public virtual ICollection<JPvssloc> JPvsslocs { get; set; } = new List<JPvssloc>();

    public virtual ICollection<JPvsstype> JPvsstypes { get; set; } = new List<JPvsstype>();
}
