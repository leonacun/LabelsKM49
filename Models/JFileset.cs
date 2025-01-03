using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFileset
{
    public decimal FisId { get; set; }

    public DateTime FisTcreation { get; set; }

    public DateTime FisTupdate { get; set; }

    public string FisKey { get; set; } = null!;

    public string FisDescr { get; set; } = null!;

    public virtual ICollection<JFile> JFiles { get; set; } = new List<JFile>();
}
