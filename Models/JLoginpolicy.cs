using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoginpolicy
{
    public decimal LpId { get; set; }

    public decimal LpCompanyId { get; set; }

    public DateTime LpTcreation { get; set; }

    public DateTime LpTupdate { get; set; }

    public string LpKey { get; set; } = null!;

    public string LpDescr { get; set; } = null!;

    public virtual ICollection<JLoginpolicyitem> JLoginpolicyitems { get; set; } = new List<JLoginpolicyitem>();

    public virtual ICollection<JUser> JUsers { get; set; } = new List<JUser>();

    public virtual ICollection<JUserset> JUsersets { get; set; } = new List<JUserset>();

    public virtual JCompany LpCompany { get; set; } = null!;
}
