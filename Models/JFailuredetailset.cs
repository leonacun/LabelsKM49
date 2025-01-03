using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFailuredetailset
{
    public decimal FdsId { get; set; }

    public decimal FdsCompanyId { get; set; }

    public DateTime FdsTcreation { get; set; }

    public DateTime FdsTupdate { get; set; }

    public string FdsKey { get; set; } = null!;

    public string FdsDescr { get; set; } = null!;

    public virtual JCompany FdsCompany { get; set; } = null!;

    public virtual ICollection<JFailuredetail> JFailuredetails { get; set; } = new List<JFailuredetail>();

    public virtual ICollection<JFailurereason> JFailurereasons { get; set; } = new List<JFailurereason>();
}
