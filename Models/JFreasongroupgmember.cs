using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFreasongroupgmember
{
    public decimal FrggmId { get; set; }

    public decimal FrggmFreasongroupId { get; set; }

    public decimal FrggmMemberfreasongroupId { get; set; }

    public DateTime FrggmTcreation { get; set; }

    public DateTime FrggmTupdate { get; set; }

    public virtual JFreasongroup FrggmFreasongroup { get; set; } = null!;

    public virtual JFreasongroup FrggmMemberfreasongroup { get; set; } = null!;
}
