using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JServerlog
{
    public decimal SerlId { get; set; }

    public decimal SerlServerId { get; set; }

    public decimal SerlTransitionId { get; set; }

    public DateTime SerlTcreation { get; set; }

    public string SerlComment { get; set; } = null!;

    public virtual JServer SerlServer { get; set; } = null!;

    public virtual JTransition SerlTransition { get; set; } = null!;
}
