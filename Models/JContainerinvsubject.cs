using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerinvsubject
{
    public decimal CtisId { get; set; }

    public decimal CtisContainerinvId { get; set; }

    public decimal CtisSubjectId { get; set; }

    public DateTime CtisTcreation { get; set; }

    public DateTime CtisTupdate { get; set; }

    public virtual JContainerinv CtisContainerinv { get; set; } = null!;

    public virtual JSubject CtisSubject { get; set; } = null!;
}
