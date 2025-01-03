using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JWorkflow
{
    public decimal WfId { get; set; }

    public decimal WfWorkflowsetId { get; set; }

    public decimal? WfConfigdefId { get; set; }

    public DateTime WfTcreation { get; set; }

    public DateTime WfTupdate { get; set; }

    public decimal? WfDeletionid { get; set; }

    public DateTime? WfTdeletion { get; set; }

    public string WfKey { get; set; } = null!;

    public string WfDescr { get; set; } = null!;

    public virtual ICollection<JWorkflowtask> JWorkflowtasks { get; set; } = new List<JWorkflowtask>();

    public virtual JConfigdef? WfConfigdef { get; set; }

    public virtual JWorkflowset WfWorkflowset { get; set; } = null!;
}
