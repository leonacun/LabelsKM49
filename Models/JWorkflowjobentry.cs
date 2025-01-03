using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JWorkflowjobentry
{
    public decimal WfjeId { get; set; }

    public decimal WfjeWorkflowjobId { get; set; }

    public decimal? WfjeSubjectId { get; set; }

    public decimal? WfjeOrderentryId { get; set; }

    public decimal? WfjeContainerentryId { get; set; }

    public DateTime WfjeTcreation { get; set; }

    public DateTime WfjeTupdate { get; set; }

    public decimal WfjeQuantity { get; set; }

    public virtual JContainerentry? WfjeContainerentry { get; set; }

    public virtual JOrderentry? WfjeOrderentry { get; set; }

    public virtual JSubject? WfjeSubject { get; set; }

    public virtual JWorkflowjob WfjeWorkflowjob { get; set; } = null!;
}
