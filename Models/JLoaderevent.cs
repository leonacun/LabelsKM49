using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoaderevent
{
    public decimal LoeId { get; set; }

    public decimal LoeLoadercontrolId { get; set; }

    public decimal? LoeContainerId { get; set; }

    public DateTime LoeTcreation { get; set; }

    public string LoeType { get; set; } = null!;

    public int LoeCycle { get; set; }

    public string? LoeMessagecode { get; set; }

    public string? LoeMessage { get; set; }

    public virtual ICollection<JLoaderparam> JLoaderparams { get; set; } = new List<JLoaderparam>();

    public virtual JContainer? LoeContainer { get; set; }

    public virtual JLoadercontrol LoeLoadercontrol { get; set; } = null!;
}
