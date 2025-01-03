using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogsubject
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string SNo { get; set; } = null!;

    public string SDescr { get; set; } = null!;

    public string? SEngineeringindex { get; set; }

    public decimal? SCompanyId { get; set; }

    public decimal? SSubjecttypeId { get; set; }

    public decimal? SSubjectstatusId { get; set; }

    public decimal? SUnitofmeasureId { get; set; }

    public virtual ICollection<JLogattrsubject> JLogattrsubjects { get; set; } = new List<JLogattrsubject>();

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
