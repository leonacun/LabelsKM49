using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvssboxtype
{
    public decimal PvbtId { get; set; }

    public decimal PvbtPvsstypeId { get; set; }

    public DateTime PvbtTcreation { get; set; }

    public DateTime PvbtTupdate { get; set; }

    public short PvbtMaxsubjectcount { get; set; }

    public byte PvbtMinfillingrate { get; set; }

    public byte PvbtSupplyfactor { get; set; }

    public string PvbtNo { get; set; } = null!;

    public virtual JPvsstype PvbtPvsstype { get; set; } = null!;
}
