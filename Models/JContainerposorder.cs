using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerposorder
{
    public decimal CtpoId { get; set; }

    public decimal CtpoContainerusageId { get; set; }

    public DateTime CtpoTcreation { get; set; }

    public DateTime CtpoTupdate { get; set; }

    public byte CtpoIndex { get; set; }

    public byte CtpoOrderindex { get; set; }

    public string CtpoType { get; set; } = null!;

    public virtual JContainerusage CtpoContainerusage { get; set; } = null!;
}
