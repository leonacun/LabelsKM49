using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JInfotemplate
{
    public decimal InfotId { get; set; }

    public DateTime InfotTcreation { get; set; }

    public DateTime InfotTupdate { get; set; }

    public string InfotInfoclassname { get; set; } = null!;

    public string InfotOwner { get; set; } = null!;

    public string InfotKey { get; set; } = null!;

    public string InfotDescr { get; set; } = null!;

    public decimal? InfotConfigdefId { get; set; }

    public virtual JConfigdef? InfotConfigdef { get; set; }
}
