using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCreditnoteset
{
    public decimal CrnsId { get; set; }

    public decimal CrnsCompanyId { get; set; }

    public DateTime CrnsTcreation { get; set; }

    public DateTime CrnsTupdate { get; set; }

    public string CrnsKey { get; set; } = null!;

    public string CrnsDescr { get; set; } = null!;

    public virtual JCompany CrnsCompany { get; set; } = null!;

    public virtual ICollection<JCreditnote> JCreditnotes { get; set; } = new List<JCreditnote>();
}
