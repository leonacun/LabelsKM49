using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderevententry
{
    public decimal OeveId { get; set; }

    public decimal OeveOrdereventId { get; set; }

    public decimal OeveSubjectId { get; set; }

    public decimal? OeveTolocationId { get; set; }

    public decimal? OeveOthersubjectId { get; set; }

    public DateTime OeveTcreation { get; set; }

    public decimal? OeveInvalidid { get; set; }

    public DateTime? OeveTvalidfrom { get; set; }

    public DateTime? OeveTvaliduntil { get; set; }

    public string? OeveNo { get; set; }

    public string? OeveVersion { get; set; }

    public string? OeveGroup { get; set; }

    public string? OeveGroupsequenceno { get; set; }

    public string OeveState { get; set; } = null!;

    public string? OeveOtherstate { get; set; }

    public bool OeveIsinternal { get; set; }

    public decimal OeveAmount { get; set; }

    public decimal OeveTransformedamount { get; set; }

    public decimal OeveAssignedamount { get; set; }

    public decimal OeveDeliveredamount { get; set; }

    public decimal OeveReceivedamount { get; set; }

    public decimal OevePaidamount { get; set; }

    public DateTime? OeveScheduledtime { get; set; }

    public DateTime? OeveCallofftime { get; set; }

    public virtual JOrderevent OeveOrderevent { get; set; } = null!;

    public virtual JSubject? OeveOthersubject { get; set; }

    public virtual JSubject OeveSubject { get; set; } = null!;

    public virtual JLocation? OeveTolocation { get; set; }
}
