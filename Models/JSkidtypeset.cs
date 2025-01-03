using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidtypeset
{
    public decimal SktsId { get; set; }

    public decimal SktsCompanyId { get; set; }

    public DateTime SktsTcreation { get; set; }

    public DateTime SktsTupdate { get; set; }

    public string SktsKey { get; set; } = null!;

    public string SktsDescr { get; set; } = null!;

    public bool SktsIsinternal { get; set; }

    public virtual JPaintunit? JPaintunit { get; set; }

    public virtual ICollection<JSkidtype> JSkidtypes { get; set; } = new List<JSkidtype>();

    public virtual JCompany SktsCompany { get; set; } = null!;
}
