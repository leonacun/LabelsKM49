using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintunitstateelem
{
    public decimal PauseId { get; set; }

    public decimal PausePaintunitstateId { get; set; }

    public decimal? PausePaintplanentryId { get; set; }

    public decimal? PauseSkidinfoId { get; set; }

    public DateTime PauseTcreation { get; set; }

    public DateTime PauseTupdate { get; set; }

    public string PauseType { get; set; } = null!;

    public string? PauseKey { get; set; }

    public decimal? PauseSkidId { get; set; }

    public virtual JPaintplanentry? PausePaintplanentry { get; set; }

    public virtual JPaintunitstate PausePaintunitstate { get; set; } = null!;

    public virtual JSkid? PauseSkid { get; set; }

    public virtual JSkidinfo? PauseSkidinfo { get; set; }
}
