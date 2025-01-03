using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAdviceset
{
    public decimal AdvsId { get; set; }

    public decimal AdvsCompanyId { get; set; }

    public decimal? AdvsCodecounterId { get; set; }

    public DateTime AdvsTcreation { get; set; }

    public DateTime AdvsTupdate { get; set; }

    public string AdvsKey { get; set; } = null!;

    public string AdvsDescr { get; set; } = null!;

    public string AdvsType { get; set; } = null!;

    public virtual JCounter? AdvsCodecounter { get; set; }

    public virtual JCompany AdvsCompany { get; set; } = null!;

    public virtual ICollection<JAdvice> JAdvices { get; set; } = new List<JAdvice>();
}
