using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainercontainer
{
    public decimal CtecId { get; set; }

    public decimal CtecContainerId { get; set; }

    public decimal CtecContainerentryId { get; set; }

    public DateTime CtecTcreation { get; set; }

    public DateTime CtecTupdate { get; set; }

    public virtual JContainer CtecContainer { get; set; } = null!;

    public virtual JContainerentry CtecContainerentry { get; set; } = null!;
}
