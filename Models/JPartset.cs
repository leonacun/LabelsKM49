using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPartset
{
    public decimal PsId { get; set; }

    public decimal PsCompanyId { get; set; }

    public decimal? PsDoccfgId { get; set; }

    public decimal? PsCounterId { get; set; }

    public DateTime PsTcreation { get; set; }

    public DateTime PsTupdate { get; set; }

    public string PsKey { get; set; } = null!;

    public string PsDescr { get; set; } = null!;

    public string? PsPartnoformat { get; set; }

    public int? PsMinpartno { get; set; }

    public int? PsMaxpartno { get; set; }

    public int? PsLastpartno { get; set; }

    public short PsMaxupdateageindays { get; set; }

    public decimal? PsEdicfgId { get; set; }

    public virtual ICollection<JPart> JParts { get; set; } = new List<JPart>();

    public virtual JCompany PsCompany { get; set; } = null!;

    public virtual JCounter? PsCounter { get; set; }

    public virtual JDoccfg? PsDoccfg { get; set; }

    public virtual JEdicfg? PsEdicfg { get; set; }
}
