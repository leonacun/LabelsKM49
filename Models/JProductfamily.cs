using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProductfamily
{
    public decimal PfId { get; set; }

    public decimal PfCompanyId { get; set; }

    public DateTime PfTcreation { get; set; }

    public DateTime PfTupdate { get; set; }

    public string PfKey { get; set; } = null!;

    public string PfDescr { get; set; } = null!;

    public virtual ICollection<JReportset> JReportsets { get; set; } = new List<JReportset>();

    public virtual ICollection<JSubjectclass> JSubjectclasses { get; set; } = new List<JSubjectclass>();

    public virtual ICollection<JSubjecttype> JSubjecttypes { get; set; } = new List<JSubjecttype>();

    public virtual JCompany PfCompany { get; set; } = null!;
}
