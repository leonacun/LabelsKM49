using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSessioninfo
{
    public decimal SessiId { get; set; }

    public decimal SessiSessionId { get; set; }

    public DateTime SessiTcreation { get; set; }

    public DateTime SessiTupdate { get; set; }

    public string SessiType { get; set; } = null!;

    public string? SessiKey1 { get; set; }

    public string? SessiKey2 { get; set; }

    public string? SessiKey3 { get; set; }

    public DateTime? SessiTimevalue { get; set; }

    public string? SessiStringvalue { get; set; }

    public virtual JSession SessiSession { get; set; } = null!;
}
