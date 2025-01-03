using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdtooladvice
{
    public decimal PtaId { get; set; }

    public decimal PtaProdtoolId { get; set; }

    public decimal PtaAdviceId { get; set; }

    public DateTime PtaTcreation { get; set; }

    public DateTime PtaTupdate { get; set; }

    public decimal? PtaConfirmedbyuserId { get; set; }

    public DateTime? PtaTimeconfirmed { get; set; }

    public virtual JAdvice PtaAdvice { get; set; } = null!;

    public virtual JUser? PtaConfirmedbyuser { get; set; }

    public virtual JProdtool PtaProdtool { get; set; } = null!;
}
