using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintjobmaterial
{
    public decimal MajmId { get; set; }

    public decimal MajmMaintjobId { get; set; }

    public decimal MajmSubjectId { get; set; }

    public decimal? MajmUnitofmeasureId { get; set; }

    public DateTime MajmTcreation { get; set; }

    public DateTime MajmTupdate { get; set; }

    public decimal MajmQuantity { get; set; }

    public virtual JMaintjob MajmMaintjob { get; set; } = null!;

    public virtual JSubject MajmSubject { get; set; } = null!;

    public virtual JUnitofmeasure? MajmUnitofmeasure { get; set; }
}
