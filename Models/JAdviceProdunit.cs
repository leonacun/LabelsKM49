using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAdviceProdunit
{
    public decimal AdviceId { get; set; }

    public decimal ProdunitId { get; set; }

    public virtual JAdvice Advice { get; set; } = null!;

    public virtual JProdunit Produnit { get; set; } = null!;
}
