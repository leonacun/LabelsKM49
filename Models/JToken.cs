using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JToken
{
    public decimal TokId { get; set; }

    public decimal TokTokensetId { get; set; }

    public decimal TokUserId { get; set; }

    public DateTime TokTcreation { get; set; }

    public DateTime TokTupdate { get; set; }

    public string TokNo { get; set; } = null!;

    public string? TokDescr { get; set; }

    public DateTime TokValiduntiltime { get; set; }

    public virtual JTokenset TokTokenset { get; set; } = null!;

    public virtual JUser TokUser { get; set; } = null!;
}
