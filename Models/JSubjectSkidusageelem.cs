using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectSkidusageelem
{
    public decimal SubjectId { get; set; }

    public decimal SkidusageelemId { get; set; }

    public DateTime Tcreation { get; set; }

    public virtual JSkidusageelem Skidusageelem { get; set; } = null!;

    public virtual JSubject Subject { get; set; } = null!;
}
