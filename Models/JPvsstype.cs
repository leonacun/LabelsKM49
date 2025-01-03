using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvsstype
{
    public decimal PvtId { get; set; }

    public decimal PvtPvssId { get; set; }

    public decimal? PvtFailurereasonsetId { get; set; }

    public decimal? PvtPvssareaId { get; set; }

    public DateTime PvtTcreation { get; set; }

    public DateTime PvtTupdate { get; set; }

    public string PvtCode { get; set; } = null!;

    public string PvtName { get; set; } = null!;

    public bool PvtIssl { get; set; }

    public bool PvtUsepvss { get; set; }

    public bool PvtCommissionfloor { get; set; }

    public bool PvtParttype { get; set; }

    public string? PvtPartgroup { get; set; }

    public DateTime? PvtTimelastsync { get; set; }

    public bool? PvtSyncrequired { get; set; }

    public virtual ICollection<JPvssboxtype> JPvssboxtypes { get; set; } = new List<JPvssboxtype>();

    public virtual ICollection<JPvssreason> JPvssreasons { get; set; } = new List<JPvssreason>();

    public virtual ICollection<JPvsssubject> JPvsssubjects { get; set; } = new List<JPvsssubject>();

    public virtual JFailurereasonset? PvtFailurereasonset { get; set; }

    public virtual JPvss PvtPvss { get; set; } = null!;

    public virtual JPvssarea? PvtPvssarea { get; set; }
}
