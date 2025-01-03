using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JReportset
{
    public decimal RsId { get; set; }

    public decimal RsCompanyId { get; set; }

    public decimal RsProductfamilyId { get; set; }

    public DateTime RsTcreation { get; set; }

    public DateTime RsTupdate { get; set; }

    public string RsKey { get; set; } = null!;

    public string RsDescr { get; set; } = null!;

    public virtual ICollection<JReport> JReports { get; set; } = new List<JReport>();

    public virtual JCompany RsCompany { get; set; } = null!;

    public virtual JProductfamily RsProductfamily { get; set; } = null!;
}
