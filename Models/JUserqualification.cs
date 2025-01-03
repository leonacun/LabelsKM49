using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUserqualification
{
    public decimal UqId { get; set; }

    public decimal UqUserId { get; set; }

    public decimal UqQualificationId { get; set; }

    public DateTime UqTcreation { get; set; }

    public DateTime UqTupdate { get; set; }

    public decimal? UqInvalidid { get; set; }

    public DateTime? UqTvalidfrom { get; set; }

    public DateTime? UqTvaliduntil { get; set; }

    public virtual ICollection<JUserqualificationevent> JUserqualificationevents { get; set; } = new List<JUserqualificationevent>();

    public virtual JQualification UqQualification { get; set; } = null!;

    public virtual JUser UqUser { get; set; } = null!;
}
