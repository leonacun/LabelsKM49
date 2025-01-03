using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdstepset
{
    public decimal PessId { get; set; }

    public decimal PessCompanyId { get; set; }

    public DateTime PessTcreation { get; set; }

    public DateTime PessTupdate { get; set; }

    public string PessKey { get; set; } = null!;

    public string PessDescr { get; set; } = null!;

    public virtual ICollection<JProdstep> JProdsteps { get; set; } = new List<JProdstep>();

    public virtual JCompany PessCompany { get; set; } = null!;
}
