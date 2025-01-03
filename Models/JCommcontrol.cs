using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCommcontrol
{
    public decimal CmcId { get; set; }

    public decimal CmcCompanyId { get; set; }

    public DateTime CmcTcreation { get; set; }

    public DateTime CmcTupdate { get; set; }

    public string CmcKey { get; set; } = null!;

    public string CmcDescr { get; set; } = null!;

    public string CmcState { get; set; } = null!;

    public byte CmcJobsize { get; set; }

    public byte CmcJobsizedelta { get; set; }

    public string CmcMode { get; set; } = null!;

    public bool CmcUseprotocol { get; set; }

    public string CmcReqmode { get; set; } = null!;

    public bool CmcRequseprotocol { get; set; }

    public DateTime? CmcLastevent { get; set; }

    public virtual JCompany CmcCompany { get; set; } = null!;

    public virtual ICollection<JCommjob> JCommjobs { get; set; } = new List<JCommjob>();

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();
}
