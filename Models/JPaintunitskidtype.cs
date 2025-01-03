using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintunitskidtype
{
    public decimal PausktId { get; set; }

    public decimal PausktPaintunitId { get; set; }

    public decimal PausktSkidtypeId { get; set; }

    public DateTime PausktTcreation { get; set; }

    public DateTime PausktTupdate { get; set; }

    public virtual JPaintunit PausktPaintunit { get; set; } = null!;

    public virtual JSkidtype PausktSkidtype { get; set; } = null!;
}
