using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JQualification
{
    public decimal QId { get; set; }

    public decimal QQualificationsetId { get; set; }

    public DateTime QTcreation { get; set; }

    public DateTime QTupdate { get; set; }

    public decimal? QDeletionid { get; set; }

    public DateTime? QTdeletion { get; set; }

    public string QKey { get; set; } = null!;

    public string QDescr { get; set; } = null!;

    public short QDuration { get; set; }

    public string QDurationscale { get; set; } = null!;

    public virtual ICollection<JQualificationclassmember> JQualificationclassmembers { get; set; } = new List<JQualificationclassmember>();

    public virtual ICollection<JUserqualification> JUserqualifications { get; set; } = new List<JUserqualification>();

    public virtual JQualificationset QQualificationset { get; set; } = null!;
}
