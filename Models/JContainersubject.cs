using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainersubject
{
    public decimal CtesId { get; set; }

    public decimal CtesSubjectId { get; set; }

    public decimal? CtesOrderentryId { get; set; }

    public decimal CtesContainerentryId { get; set; }

    public decimal? CtesUnitofmeasureId { get; set; }

    public DateTime CtesTcreation { get; set; }

    public DateTime CtesTupdate { get; set; }

    public decimal CtesAmount { get; set; }

    public virtual JContainerentry CtesContainerentry { get; set; } = null!;

    public virtual JOrderentry? CtesOrderentry { get; set; }

    public virtual JSubject CtesSubject { get; set; } = null!;

    public virtual JUnitofmeasure? CtesUnitofmeasure { get; set; }

    public virtual JContainersubjectmark? JContainersubjectmark { get; set; }
}
