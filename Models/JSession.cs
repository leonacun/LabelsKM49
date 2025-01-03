using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSession
{
    public decimal SessId { get; set; }

    public decimal SessCompanyId { get; set; }

    public DateTime SessTcreation { get; set; }

    public DateTime SessTupdate { get; set; }

    public string? SessUser { get; set; }

    public string? SessTool { get; set; }

    public string? SessWorkstation { get; set; }

    public DateTime? SessTimeended { get; set; }

    public virtual ICollection<JLogentry> JLogentries { get; set; } = new List<JLogentry>();

    public virtual ICollection<JObjectlog> JObjectlogs { get; set; } = new List<JObjectlog>();

    public virtual ICollection<JSessioninfo> JSessioninfos { get; set; } = new List<JSessioninfo>();

    public virtual ICollection<JTransition> JTransitions { get; set; } = new List<JTransition>();

    public virtual JCompany SessCompany { get; set; } = null!;
}
