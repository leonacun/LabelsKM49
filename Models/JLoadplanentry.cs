using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoadplanentry
{
    public decimal LpeId { get; set; }

    public decimal LpeTourId { get; set; }

    public decimal? LpeSubjectId { get; set; }

    public decimal? LpeOrderentryId { get; set; }

    public DateTime LpeTcreation { get; set; }

    public DateTime LpeTupdate { get; set; }

    public decimal LpeQuantity { get; set; }

    public decimal? LpeDeliverynoteId { get; set; }

    public virtual ICollection<JLoadplanentryinfo> JLoadplanentryinfos { get; set; } = new List<JLoadplanentryinfo>();

    public virtual JDeliverynote? LpeDeliverynote { get; set; }

    public virtual JOrderentry? LpeOrderentry { get; set; }

    public virtual JSubject? LpeSubject { get; set; }

    public virtual JTour LpeTour { get; set; } = null!;
}
