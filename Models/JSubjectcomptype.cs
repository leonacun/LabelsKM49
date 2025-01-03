using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectcomptype
{
    public decimal SctId { get; set; }

    public decimal SctCompanyId { get; set; }

    public DateTime SctTcreation { get; set; }

    public DateTime SctTupdate { get; set; }

    public string SctKey { get; set; } = null!;

    public string? SctDescr { get; set; }

    public virtual ICollection<JProdflowusage> JProdflowusages { get; set; } = new List<JProdflowusage>();

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JSubjectattrpropa> JSubjectattrpropas { get; set; } = new List<JSubjectattrpropa>();

    public virtual ICollection<JSubjectcomp> JSubjectcomps { get; set; } = new List<JSubjectcomp>();

    public virtual JCompany SctCompany { get; set; } = null!;
}
