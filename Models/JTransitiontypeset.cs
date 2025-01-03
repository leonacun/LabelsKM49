using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransitiontypeset
{
    public decimal TrtsId { get; set; }

    public decimal TrtsCompanyId { get; set; }

    public DateTime TrtsTcreation { get; set; }

    public DateTime TrtsTupdate { get; set; }

    public string TrtsKey { get; set; } = null!;

    public string TrtsDescr { get; set; } = null!;

    public virtual ICollection<JTransitiontype> JTransitiontypes { get; set; } = new List<JTransitiontype>();

    public virtual JCompany TrtsCompany { get; set; } = null!;
}
