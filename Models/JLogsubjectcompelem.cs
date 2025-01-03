using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogsubjectcompelem
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public decimal SceProdquantity { get; set; }

    public decimal SceQuantity { get; set; }

    public string? SceInfo { get; set; }

    public decimal? SceSubjectcompId { get; set; }

    public decimal? SceUsedsubjectId { get; set; }

    public decimal? SceProdstepId { get; set; }

    public decimal? SceUnitofmeasureId { get; set; }

    public decimal? SceProdunitofmeasureId { get; set; }

    public decimal? SceInvalidid { get; set; }

    public DateTime? SceTvalidfrom { get; set; }

    public DateTime? SceTvaliduntil { get; set; }

    public string? SceNo { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
