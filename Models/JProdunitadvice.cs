using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitadvice
{
    public decimal PuaId { get; set; }

    public decimal PuaProdunitId { get; set; }

    public decimal PuaAdviceId { get; set; }

    public decimal? PuaConfirmedbyuserId { get; set; }

    public DateTime PuaTcreation { get; set; }

    public DateTime PuaTupdate { get; set; }

    public DateTime? PuaTimeconfirmed { get; set; }

    public virtual JAdvice PuaAdvice { get; set; } = null!;

    public virtual JUser? PuaConfirmedbyuser { get; set; }

    public virtual JProdunit PuaProdunit { get; set; } = null!;
}
