using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintdefmaterial
{
    public decimal MadmId { get; set; }

    public decimal MadmMaintdefId { get; set; }

    public decimal MadmSubjectId { get; set; }

    public decimal? MadmUnitofmeasureId { get; set; }

    public DateTime MadmTcreation { get; set; }

    public DateTime MadmTupdate { get; set; }

    public decimal MadmQuantity { get; set; }

    public virtual JMaintdef MadmMaintdef { get; set; } = null!;

    public virtual JSubject MadmSubject { get; set; } = null!;

    public virtual JUnitofmeasure? MadmUnitofmeasure { get; set; }
}
