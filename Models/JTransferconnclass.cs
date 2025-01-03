using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransferconnclass
{
    public decimal TcclId { get; set; }

    public decimal TcclCompanyId { get; set; }

    public DateTime TcclTcreation { get; set; }

    public DateTime TcclTupdate { get; set; }

    public string TcclKey { get; set; } = null!;

    public string TcclDescr { get; set; } = null!;

    public virtual ICollection<JTransferconnclassm> JTransferconnclassms { get; set; } = new List<JTransferconnclassm>();

    public virtual JCompany TcclCompany { get; set; } = null!;
}
