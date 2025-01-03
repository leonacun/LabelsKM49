using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContractnote
{
    public decimal CnoId { get; set; }

    public decimal CnoContractId { get; set; }

    public DateTime CnoTcreation { get; set; }

    public DateTime CnoTupdate { get; set; }

    public string CnoNo { get; set; } = null!;

    public string CnoDescr { get; set; } = null!;

    public virtual JContract CnoContract { get; set; } = null!;

    public virtual ICollection<JContractnoteentry> JContractnoteentries { get; set; } = new List<JContractnoteentry>();
}
