using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLocationclassmember
{
    public decimal LcmId { get; set; }

    public decimal LcmLocationclassId { get; set; }

    public decimal LcmLocationId { get; set; }

    public DateTime LcmTcreation { get; set; }

    public DateTime LcmTupdate { get; set; }

    public virtual JLocation LcmLocation { get; set; } = null!;

    public virtual JLocationclass LcmLocationclass { get; set; } = null!;
}
