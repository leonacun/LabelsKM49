using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JWorkflowjob
{
    public decimal WfjId { get; set; }

    public decimal WfjWorkflowjobsetId { get; set; }

    public DateTime WfjTcreation { get; set; }

    public DateTime WfjTupdate { get; set; }

    public decimal? WfjDeletionid { get; set; }

    public DateTime? WfjTdeletion { get; set; }

    public string WfjNo { get; set; } = null!;

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual ICollection<JWorkflowjobentry> JWorkflowjobentries { get; set; } = new List<JWorkflowjobentry>();

    public virtual JWorkflowjobset WfjWorkflowjobset { get; set; } = null!;
}
