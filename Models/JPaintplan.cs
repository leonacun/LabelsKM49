using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintplan
{
    public decimal PpId { get; set; }

    public decimal PpPaintunitId { get; set; }

    public decimal? PpPaintplantemplateId { get; set; }

    public DateTime PpTcreation { get; set; }

    public DateTime PpTupdate { get; set; }

    public string PpNo { get; set; } = null!;

    public string PpState { get; set; } = null!;

    public byte PpVersion { get; set; }

    public byte PpLastsyncerrors { get; set; }

    public DateTime? PpLoadingtime { get; set; }

    public byte PpPosdelta { get; set; }

    public int PpRound { get; set; }

    public virtual ICollection<JPaintplanentry> JPaintplanentries { get; set; } = new List<JPaintplanentry>();

    public virtual ICollection<JSkidinfo> JSkidinfos { get; set; } = new List<JSkidinfo>();

    public virtual JPaintplantemplate? PpPaintplantemplate { get; set; }

    public virtual JPaintunit PpPaintunit { get; set; } = null!;
}
