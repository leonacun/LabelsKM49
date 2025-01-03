using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoadercontrol
{
    public decimal LocId { get; set; }

    public decimal LocToursetId { get; set; }

    public DateTime LocTcreation { get; set; }

    public DateTime LocTupdate { get; set; }

    public string LocKey { get; set; } = null!;

    public string LocDescr { get; set; } = null!;

    public int LocCycle { get; set; }

    public string? LocCyclecomment { get; set; }

    public int LocDonecontainercount { get; set; }

    public virtual ICollection<JLoaderevent> JLoaderevents { get; set; } = new List<JLoaderevent>();

    public virtual ICollection<JLoaderparam> JLoaderparams { get; set; } = new List<JLoaderparam>();

    public virtual JTourset LocTourset { get; set; } = null!;
}
