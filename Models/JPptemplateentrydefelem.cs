using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPptemplateentrydefelem
{
    public decimal PptedeId { get; set; }

    public decimal PptedePptemplateentryId { get; set; }

    public decimal PptedeRawsubjectId { get; set; }

    public DateTime PptedeTcreation { get; set; }

    public byte PptedeIndex { get; set; }

    public decimal PptedeQuantity { get; set; }

    public virtual JPaintplantemplateentry PptedePptemplateentry { get; set; } = null!;

    public virtual JSubject PptedeRawsubject { get; set; } = null!;
}
