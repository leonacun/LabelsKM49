using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintplantemplate
{
    public decimal PptId { get; set; }

    public decimal PptPaintunitId { get; set; }

    public DateTime PptTcreation { get; set; }

    public DateTime PptTupdate { get; set; }

    public decimal? PptDeletionid { get; set; }

    public DateTime? PptTdeletion { get; set; }

    public string PptShortname { get; set; } = null!;

    public string PptDescr { get; set; } = null!;

    public string PptState { get; set; } = null!;

    public DateTime? PptTimeexported { get; set; }

    public virtual ICollection<JPaintplan> JPaintplans { get; set; } = new List<JPaintplan>();

    public virtual ICollection<JPaintplantemplateentry> JPaintplantemplateentries { get; set; } = new List<JPaintplantemplateentry>();

    public virtual JPaintunit PptPaintunit { get; set; } = null!;
}
