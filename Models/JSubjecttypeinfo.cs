using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjecttypeinfo
{
    public decimal StyiId { get; set; }

    public decimal StyiSubjecttypeId { get; set; }

    public DateTime StyiTcreation { get; set; }

    public DateTime StyiTupdate { get; set; }

    public string StyiType { get; set; } = null!;

    public string? StyiKey1 { get; set; }

    public string? StyiKey2 { get; set; }

    public string? StyiKey3 { get; set; }

    public DateTime? StyiTimevalue { get; set; }

    public string? StyiStringvalue { get; set; }

    public virtual JSubjecttype StyiSubjecttype { get; set; } = null!;
}
