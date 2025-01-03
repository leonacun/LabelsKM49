using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdevent
{
    public decimal PreId { get; set; }

    public decimal PreProdeventsetId { get; set; }

    public decimal? PreProdstepId { get; set; }

    public decimal PreSubjectId { get; set; }

    public decimal? PreTransitionId { get; set; }

    public decimal? PreProdunitId { get; set; }

    public decimal? PrePartId { get; set; }

    public decimal? PreProdjobentryId { get; set; }

    public decimal? PreProdtoolusageId { get; set; }

    public DateTime PreTcreation { get; set; }

    public decimal PreAmount { get; set; }

    public DateTime PreTimestamp { get; set; }

    public DateTime? PreExported { get; set; }

    public string PreQualityclass { get; set; } = null!;

    public string? PreLocation { get; set; }

    public string? PreQualifier { get; set; }

    public decimal? PrePaintplanentryId { get; set; }

    public decimal? PreContainerentryId { get; set; }

    public virtual ICollection<JProdeventdatum> JProdeventdata { get; set; } = new List<JProdeventdatum>();

    public virtual ICollection<JProdeventexport> JProdeventexports { get; set; } = new List<JProdeventexport>();

    public virtual JContainerentry? PreContainerentry { get; set; }

    public virtual JPaintplanentry? PrePaintplanentry { get; set; }

    public virtual JPart? PrePart { get; set; }

    public virtual JProdeventset PreProdeventset { get; set; } = null!;

    public virtual JProdjobentry? PreProdjobentry { get; set; }

    public virtual JProdstep? PreProdstep { get; set; }

    public virtual JProdtoolusage? PreProdtoolusage { get; set; }

    public virtual JProdunit? PreProdunit { get; set; }

    public virtual JSubject PreSubject { get; set; } = null!;

    public virtual JTransition? PreTransition { get; set; }
}
