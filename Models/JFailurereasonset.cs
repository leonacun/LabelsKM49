using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFailurereasonset
{
    public decimal FrsId { get; set; }

    public decimal FrsCompanyId { get; set; }

    public DateTime FrsTcreation { get; set; }

    public DateTime FrsTupdate { get; set; }

    public string FrsKey { get; set; } = null!;

    public string FrsDescr { get; set; } = null!;

    public virtual JCompany FrsCompany { get; set; } = null!;

    public virtual ICollection<JFailurereason> JFailurereasons { get; set; } = new List<JFailurereason>();

    public virtual ICollection<JFreasongroup> JFreasongroups { get; set; } = new List<JFreasongroup>();

    public virtual ICollection<JProdstep> JProdsteps { get; set; } = new List<JProdstep>();

    public virtual ICollection<JProdunit> JProdunitPuConditionreasonsets { get; set; } = new List<JProdunit>();

    public virtual ICollection<JProdunit> JProdunitPuDowntimereasonsets { get; set; } = new List<JProdunit>();

    public virtual ICollection<JProdunit> JProdunitPuInterruptreasonsets { get; set; } = new List<JProdunit>();

    public virtual ICollection<JPvsstype> JPvsstypes { get; set; } = new List<JPvsstype>();
}
