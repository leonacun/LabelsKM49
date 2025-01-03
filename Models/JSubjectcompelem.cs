using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectcompelem
{
    public decimal SceId { get; set; }

    public decimal SceSubjectcompId { get; set; }

    public decimal SceUsedsubjectId { get; set; }

    public decimal? SceProdstepId { get; set; }

    public decimal? SceUnitofmeasureId { get; set; }

    public decimal? SceProdunitofmeasureId { get; set; }

    public DateTime SceTcreation { get; set; }

    public DateTime SceTupdate { get; set; }

    public decimal? SceInvalidid { get; set; }

    public DateTime? SceTvalidfrom { get; set; }

    public DateTime? SceTvaliduntil { get; set; }

    public decimal SceProdquantity { get; set; }

    public decimal SceQuantity { get; set; }

    public string? SceInfo { get; set; }

    public string? SceNo { get; set; }

    public virtual JProdstep? SceProdstep { get; set; }

    public virtual JUnitofmeasure? SceProdunitofmeasure { get; set; }

    public virtual JSubjectcomp SceSubjectcomp { get; set; } = null!;

    public virtual JUnitofmeasure? SceUnitofmeasure { get; set; }

    public virtual JSubject SceUsedsubject { get; set; } = null!;
}
