using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogsubjectcomp
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public decimal? ScSubjectcomptypeId { get; set; }

    public decimal? ScProducedsubjectId { get; set; }

    public decimal? ScInvalidid { get; set; }

    public DateTime? ScTvalidfrom { get; set; }

    public DateTime? ScTvaliduntil { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
