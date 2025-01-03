using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobbufferentry
{
    public decimal PjbeId { get; set; }

    public decimal PjbeProdjobbufferId { get; set; }

    public decimal PjbeProdjobId { get; set; }

    public DateTime PjbeTcreation { get; set; }

    public DateTime PjbeTupdate { get; set; }

    public int PjbeNo { get; set; }

    public virtual JProdjob PjbeProdjob { get; set; } = null!;

    public virtual JProdjobbuffer PjbeProdjobbuffer { get; set; } = null!;
}
