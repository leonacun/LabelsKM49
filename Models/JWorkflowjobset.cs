using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JWorkflowjobset
{
    public decimal WfjsId { get; set; }

    public decimal WfjsCompanyId { get; set; }

    public decimal? WfjsCounterId { get; set; }

    public DateTime WfjsTcreation { get; set; }

    public DateTime WfjsTupdate { get; set; }

    public string WfjsKey { get; set; } = null!;

    public string WfjsDescr { get; set; } = null!;

    public virtual ICollection<JWorkflowjob> JWorkflowjobs { get; set; } = new List<JWorkflowjob>();

    public virtual JCompany WfjsCompany { get; set; } = null!;

    public virtual JCounter? WfjsCounter { get; set; }
}
