using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogcontainersubject
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public decimal CtesAmount { get; set; }

    public decimal? CtesSubjectId { get; set; }

    public decimal? CtesOrderentryId { get; set; }

    public decimal? CtesContainerentryId { get; set; }

    public decimal? CtesUnitofmeasureId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
