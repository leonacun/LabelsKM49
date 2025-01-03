using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTrucktype
{
    public decimal TtId { get; set; }

    public decimal TtCompanyId { get; set; }

    public DateTime TtTcreation { get; set; }

    public DateTime TtTupdate { get; set; }

    public string TtShortname { get; set; } = null!;

    public string TtDescr { get; set; } = null!;

    public byte TtMaxcontainers { get; set; }

    public virtual ICollection<JTour> JTours { get; set; } = new List<JTour>();

    public virtual ICollection<JTourtemplate> JTourtemplates { get; set; } = new List<JTourtemplate>();

    public virtual ICollection<JTrucktypeinfo> JTrucktypeinfos { get; set; } = new List<JTrucktypeinfo>();

    public virtual JCompany TtCompany { get; set; } = null!;
}
