using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintjobset
{
    public decimal MajsId { get; set; }

    public decimal MajsCompanyId { get; set; }

    public DateTime MajsTcreation { get; set; }

    public DateTime MajsTupdate { get; set; }

    public string MajsKey { get; set; } = null!;

    public string MajsDescr { get; set; } = null!;

    public decimal? MajsDoccfgId { get; set; }

    public virtual ICollection<JMaintjob> JMaintjobs { get; set; } = new List<JMaintjob>();

    public virtual JCompany MajsCompany { get; set; } = null!;

    public virtual JDoccfg? MajsDoccfg { get; set; }
}
