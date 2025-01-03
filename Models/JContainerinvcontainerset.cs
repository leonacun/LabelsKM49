using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerinvcontainerset
{
    public decimal CtictsId { get; set; }

    public decimal CtictsContainerinvId { get; set; }

    public decimal CtictsContainersetId { get; set; }

    public decimal CtictsInvcontainersetId { get; set; }

    public DateTime CtictsTcreation { get; set; }

    public DateTime CtictsTupdate { get; set; }

    public virtual JContainerinv CtictsContainerinv { get; set; } = null!;

    public virtual JContainerset CtictsContainerset { get; set; } = null!;

    public virtual JContainerset CtictsInvcontainerset { get; set; } = null!;
}
