using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerbufferclassm
{
    public decimal CtbcmId { get; set; }

    public decimal CtbcmContainerbufferclassId { get; set; }

    public decimal CtbcmContainerbufferId { get; set; }

    public DateTime CtbcmTcreation { get; set; }

    public DateTime CtbcmTupdate { get; set; }

    public virtual JContainerbuffer CtbcmContainerbuffer { get; set; } = null!;

    public virtual JContainerbufferclass CtbcmContainerbufferclass { get; set; } = null!;
}
