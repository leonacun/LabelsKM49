using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdflowusage
{
    public decimal PfluId { get; set; }

    public decimal? PfluProdflowId { get; set; }

    public decimal? PfluSubjectId { get; set; }

    public decimal? PfluSubjecttypeId { get; set; }

    public DateTime PfluTcreation { get; set; }

    public decimal? PfluSubjectcomptypeId { get; set; }

    public decimal? PfluProdunitId { get; set; }

    public decimal? PfluInvalidid { get; set; }

    public DateTime? PfluTvalidfrom { get; set; }

    public DateTime? PfluTvaliduntil { get; set; }

    public string? PfluCode { get; set; }

    public bool? PfluEnabled { get; set; }

    public virtual ICollection<JProdversionclassmember> JProdversionclassmembers { get; set; } = new List<JProdversionclassmember>();

    public virtual ICollection<JProdversioninfo> JProdversioninfos { get; set; } = new List<JProdversioninfo>();

    public virtual JProdflow? PfluProdflow { get; set; }

    public virtual JProdunit? PfluProdunit { get; set; }

    public virtual JSubject? PfluSubject { get; set; }

    public virtual JSubjectcomptype? PfluSubjectcomptype { get; set; }

    public virtual JSubjecttype? PfluSubjecttype { get; set; }
}
