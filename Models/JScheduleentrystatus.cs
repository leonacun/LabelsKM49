using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JScheduleentrystatus
{
    public decimal SchesId { get; set; }

    public decimal SchesScheduleentryId { get; set; }

    public DateTime SchesTcreation { get; set; }

    public DateTime SchesTupdate { get; set; }

    public string SchesDevqualifier { get; set; } = null!;

    public decimal? SchesDevquantity { get; set; }

    public string? SchesDevcomment { get; set; }

    public virtual JScheduleentry SchesScheduleentry { get; set; } = null!;
}
