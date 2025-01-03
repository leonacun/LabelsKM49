using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectinfo
{
    public decimal SiId { get; set; }

    public decimal SiSubjectId { get; set; }

    public DateTime SiTcreation { get; set; }

    public DateTime SiTupdate { get; set; }

    public decimal? SiInvalidid { get; set; }

    public DateTime? SiTvalidfrom { get; set; }

    public DateTime? SiTvaliduntil { get; set; }

    public string SiType { get; set; } = null!;

    public string? SiKey { get; set; }

    public string? SiValue { get; set; }

    public decimal? SiRefsubjectId { get; set; }

    public virtual JSubject? SiRefsubject { get; set; }

    public virtual JSubject SiSubject { get; set; } = null!;
}
