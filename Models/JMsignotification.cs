using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMsignotification
{
    public decimal MsignId { get; set; }

    public decimal MsignProdjobentryId { get; set; }

    public decimal MsignContainerentryId { get; set; }

    public decimal? MsignCompstockId { get; set; }

    public decimal? MsignCompsubjectId { get; set; }

    public decimal? MsignTransitstockId { get; set; }

    public DateTime MsignTcreation { get; set; }

    public decimal? MsignDeletionid { get; set; }

    public DateTime? MsignTdeletion { get; set; }

    public DateTime MsignNextduetime { get; set; }

    public byte MsignRepetitions { get; set; }

    public virtual JStock? MsignCompstock { get; set; }

    public virtual JSubject? MsignCompsubject { get; set; }

    public virtual JContainerentry MsignContainerentry { get; set; } = null!;

    public virtual JProdjobentry MsignProdjobentry { get; set; } = null!;

    public virtual JStock? MsignTransitstock { get; set; }
}
