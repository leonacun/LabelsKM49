using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainertypeset
{
    public decimal CttsId { get; set; }

    public decimal CttsCompanyId { get; set; }

    public DateTime CttsTcreation { get; set; }

    public DateTime CttsTupdate { get; set; }

    public string CttsKey { get; set; } = null!;

    public string CttsDescr { get; set; } = null!;

    public virtual JCompany CttsCompany { get; set; } = null!;

    public virtual ICollection<JContainertypeclass> JContainertypeclasses { get; set; } = new List<JContainertypeclass>();

    public virtual ICollection<JContainertype> JContainertypes { get; set; } = new List<JContainertype>();
}
