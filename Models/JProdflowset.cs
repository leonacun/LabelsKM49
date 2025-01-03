using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdflowset
{
    public decimal PflsId { get; set; }

    public decimal PflsCompanyId { get; set; }

    public DateTime PflsTcreation { get; set; }

    public DateTime PflsTupdate { get; set; }

    public string PflsKey { get; set; } = null!;

    public string PflsDescr { get; set; } = null!;

    public virtual ICollection<JProdflow> JProdflows { get; set; } = new List<JProdflow>();

    public virtual JCompany PflsCompany { get; set; } = null!;
}
