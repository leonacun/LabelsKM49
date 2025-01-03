using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdtoolusageelem
{
    public decimal PtueId { get; set; }

    public decimal PtueProdtoolusageId { get; set; }

    public decimal? PtueSubjectId { get; set; }

    public decimal? PtueSubjectclassId { get; set; }

    public DateTime PtueTcreation { get; set; }

    public DateTime PtueTupdate { get; set; }

    public decimal PtueQuantity { get; set; }

    public string? PtueParams { get; set; }

    public decimal PtueMincycletimeinsec { get; set; }

    public string? PtueCavity { get; set; }

    public string? PtueDoccfgitemrole { get; set; }

    public virtual ICollection<JProdplanentryelem> JProdplanentryelems { get; set; } = new List<JProdplanentryelem>();

    public virtual JProdtoolusage PtueProdtoolusage { get; set; } = null!;

    public virtual JSubject? PtueSubject { get; set; }

    public virtual JSubjectclass? PtueSubjectclass { get; set; }
}
