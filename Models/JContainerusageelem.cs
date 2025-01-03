using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerusageelem
{
    public decimal CtueId { get; set; }

    public decimal CtueContainerusageId { get; set; }

    public decimal? CtueSubjectId { get; set; }

    public DateTime CtueTcreation { get; set; }

    public DateTime CtueTupdate { get; set; }

    public decimal CtueMaxamount { get; set; }

    public virtual JContainerusage CtueContainerusage { get; set; } = null!;

    public virtual JSubject? CtueSubject { get; set; }
}
