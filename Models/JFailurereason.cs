using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFailurereason
{
    public decimal FrId { get; set; }

    public decimal FrFreasonsetId { get; set; }

    public decimal? FrFdetailsetId { get; set; }

    public DateTime FrTcreation { get; set; }

    public DateTime FrTupdate { get; set; }

    public decimal? FrInvalidid { get; set; }

    public DateTime? FrTvalidfrom { get; set; }

    public DateTime? FrTvaliduntil { get; set; }

    public string FrCode { get; set; } = null!;

    public string FrDescr { get; set; } = null!;

    public string FrQualityclass { get; set; } = null!;

    public string? FrKey { get; set; }

    public virtual JFailuredetailset? FrFdetailset { get; set; }

    public virtual JFailurereasonset FrFreasonset { get; set; } = null!;

    public virtual ICollection<JFailurereasonclassmember> JFailurereasonclassmembers { get; set; } = new List<JFailurereasonclassmember>();

    public virtual ICollection<JFreasongroupmember> JFreasongroupmembers { get; set; } = new List<JFreasongroupmember>();

    public virtual ICollection<JProdeventdatum> JProdeventdata { get; set; } = new List<JProdeventdatum>();

    public virtual ICollection<JProdplanentryelem> JProdplanentryelems { get; set; } = new List<JProdplanentryelem>();

    public virtual ICollection<JProduniteventdatum> JProduniteventdata { get; set; } = new List<JProduniteventdatum>();

    public virtual ICollection<JProdunitinterval> JProdunitintervals { get; set; } = new List<JProdunitinterval>();

    public virtual ICollection<JPvssreason> JPvssreasons { get; set; } = new List<JPvssreason>();

    public virtual ICollection<JSupplynoteinfo> JSupplynoteinfos { get; set; } = new List<JSupplynoteinfo>();

    public virtual ICollection<JTicket> JTickets { get; set; } = new List<JTicket>();
}
