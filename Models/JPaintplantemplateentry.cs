using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintplantemplateentry
{
    public decimal PpteId { get; set; }

    public decimal PptePaintplantemplateId { get; set; }

    public decimal PpteSkidtypeId { get; set; }

    public DateTime PpteTcreation { get; set; }

    public DateTime PpteTupdate { get; set; }

    public byte PptePos { get; set; }

    public decimal PpteQuantity { get; set; }

    public bool PpteNewgroup { get; set; }

    public bool PpteDefempty { get; set; }

    public string? PpteDefskidusageshortname { get; set; }

    public virtual ICollection<JPptemplateentrydefelem> JPptemplateentrydefelems { get; set; } = new List<JPptemplateentrydefelem>();

    public virtual JPaintplantemplate PptePaintplantemplate { get; set; } = null!;

    public virtual JSkidtype PpteSkidtype { get; set; } = null!;
}
