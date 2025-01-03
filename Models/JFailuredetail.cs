using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFailuredetail
{
    public decimal FdId { get; set; }

    public decimal FdFdetailsetId { get; set; }

    public DateTime FdTcreation { get; set; }

    public string FdCode { get; set; } = null!;

    public string FdDescr { get; set; } = null!;

    public virtual JFailuredetailset FdFdetailset { get; set; } = null!;

    public virtual ICollection<JProdeventdatum> JProdeventdata { get; set; } = new List<JProdeventdatum>();
}
