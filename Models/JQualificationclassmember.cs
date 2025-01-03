using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JQualificationclassmember
{
    public decimal QcmId { get; set; }

    public decimal QcmQualificationclassId { get; set; }

    public decimal QcmQualificationId { get; set; }

    public DateTime QcmTcreation { get; set; }

    public DateTime QcmTupdate { get; set; }

    public virtual JQualification QcmQualification { get; set; } = null!;

    public virtual JQualificationclass QcmQualificationclass { get; set; } = null!;
}
