using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidtypecolor
{
    public decimal SktcId { get; set; }

    public decimal SktcColorId { get; set; }

    public decimal SktcSkidtypeId { get; set; }

    public DateTime SktcTcreation { get; set; }

    public DateTime SktcTupdate { get; set; }

    public bool SktcLocked { get; set; }

    public virtual JColor SktcColor { get; set; } = null!;

    public virtual JSkidtype SktcSkidtype { get; set; } = null!;
}
