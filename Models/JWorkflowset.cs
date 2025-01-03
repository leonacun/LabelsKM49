using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JWorkflowset
{
    public decimal WfsId { get; set; }

    public decimal WfsCompanyId { get; set; }

    public DateTime WfsTcreation { get; set; }

    public DateTime WfsTupdate { get; set; }

    public string WfsKey { get; set; } = null!;

    public string WfsDescr { get; set; } = null!;

    public virtual ICollection<JWorkflow> JWorkflows { get; set; } = new List<JWorkflow>();

    public virtual JCompany WfsCompany { get; set; } = null!;
}
