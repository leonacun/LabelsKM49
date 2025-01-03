using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderproclog
{
    public decimal OplId { get; set; }

    public decimal OplContractId { get; set; }

    public DateTime OplTcreation { get; set; }

    public string OplType { get; set; } = null!;

    public string OplQualifier1 { get; set; } = null!;

    public string? OplQualifier2 { get; set; }

    public string? OplQualifier3 { get; set; }

    public DateTime? OplTimevalue { get; set; }

    public int OplCount { get; set; }

    public virtual JContract OplContract { get; set; } = null!;
}
