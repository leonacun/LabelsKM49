using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectattrinfo
{
    public decimal SaiId { get; set; }

    public decimal SaiSubjectattrId { get; set; }

    public DateTime SaiTcreation { get; set; }

    public DateTime SaiTupdate { get; set; }

    public string SaiType { get; set; } = null!;

    public string? SaiKey1 { get; set; }

    public string? SaiKey2 { get; set; }

    public string? SaiKey3 { get; set; }

    public DateTime? SaiTimevalue { get; set; }

    public string? SaiStringvalue { get; set; }

    public virtual JSubjectattr SaiSubjectattr { get; set; } = null!;
}
