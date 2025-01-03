using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvsssubject
{
    public decimal PvsId { get; set; }

    public decimal PvsPvsstypeId { get; set; }

    public decimal PvsSubjectId { get; set; }

    public decimal? PvsColorId { get; set; }

    public DateTime PvsTcreation { get; set; }

    public DateTime PvsTupdate { get; set; }

    public bool PvsHasstock { get; set; }

    public bool PvsCommexternal { get; set; }

    public bool PvsLaqposmessage { get; set; }

    public DateTime? PvsTimelastsync { get; set; }

    public bool? PvsSyncrequired { get; set; }

    public virtual ICollection<JPvsscomp> JPvsscomps { get; set; } = new List<JPvsscomp>();

    public virtual ICollection<JPvssloc> JPvsslocs { get; set; } = new List<JPvssloc>();

    public virtual JColor? PvsColor { get; set; }

    public virtual JPvsstype PvsPvsstype { get; set; } = null!;

    public virtual JSubject PvsSubject { get; set; } = null!;
}
