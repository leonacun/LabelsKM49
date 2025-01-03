using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerposorderoption
{
    public decimal CtpooId { get; set; }

    public decimal CtpooContainerusageId { get; set; }

    public DateTime CtpooTcreation { get; set; }

    public string CtpooType { get; set; } = null!;

    public bool? CtpooEnabled { get; set; }

    public virtual JContainerusage CtpooContainerusage { get; set; } = null!;
}
