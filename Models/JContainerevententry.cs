using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerevententry
{
    public decimal CteveId { get; set; }

    public decimal CteveContainereventId { get; set; }

    public decimal? CteveSubjectId { get; set; }

    public DateTime CteveTcreation { get; set; }

    public short CteveIndex { get; set; }

    public string? CtevePos { get; set; }

    public decimal CteveAmount { get; set; }

    public virtual JContainerevent CteveContainerevent { get; set; } = null!;

    public virtual JSubject? CteveSubject { get; set; }
}
