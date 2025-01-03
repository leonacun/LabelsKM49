using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTokenset
{
    public decimal ToksId { get; set; }

    public decimal ToksCompanyId { get; set; }

    public DateTime ToksTcreation { get; set; }

    public DateTime ToksTupdate { get; set; }

    public string ToksKey { get; set; } = null!;

    public string ToksDescr { get; set; } = null!;

    public byte ToksTokenlength { get; set; }

    public byte ToksValidityinminutes { get; set; }

    public virtual ICollection<JToken> JTokens { get; set; } = new List<JToken>();

    public virtual JCompany ToksCompany { get; set; } = null!;
}
