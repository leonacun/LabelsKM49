using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAdviceconfirmation
{
    public decimal AdvcId { get; set; }

    public decimal AdvcAdviceId { get; set; }

    public decimal? AdvcConfirmedbyuserId { get; set; }

    public DateTime AdvcTcreation { get; set; }

    public decimal? AdvcProdtoolId { get; set; }

    public decimal? AdvcProdunitId { get; set; }

    public virtual JAdvice AdvcAdvice { get; set; } = null!;

    public virtual JUser? AdvcConfirmedbyuser { get; set; }

    public virtual JProdtool? AdvcProdtool { get; set; }

    public virtual JProdunit? AdvcProdunit { get; set; }
}
