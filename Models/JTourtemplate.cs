using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTourtemplate
{
    public decimal TteId { get; set; }

    public decimal TteToursetId { get; set; }

    public decimal? TteTrucktypeId { get; set; }

    public decimal? TteCarrierId { get; set; }

    public decimal? TteShortnameId { get; set; }

    public decimal? TteBorderocounterId { get; set; }

    public DateTime TteTcreation { get; set; }

    public DateTime TteTupdate { get; set; }

    public string TteKey { get; set; } = null!;

    public string? TteDescr { get; set; }

    public string? TteTourdescr { get; set; }

    public byte TteLoadingadvinminutes { get; set; }

    public string TteTransportmedia { get; set; } = null!;

    public byte TteTransportinminutes { get; set; }

    public decimal? TteScriptdefId { get; set; }

    public int TteLoadsizex { get; set; }

    public int TteLoadsizey { get; set; }

    public int TteLoadsizez { get; set; }

    public decimal? TteComponentdefId { get; set; }

    public virtual ICollection<JToureventcfg> JToureventcfgs { get; set; } = new List<JToureventcfg>();

    public virtual ICollection<JTourtemplateinfo> JTourtemplateinfos { get; set; } = new List<JTourtemplateinfo>();

    public virtual JCounter? TteBorderocounter { get; set; }

    public virtual JCompany? TteCarrier { get; set; }

    public virtual JComponentdef? TteComponentdef { get; set; }

    public virtual JScriptdef? TteScriptdef { get; set; }

    public virtual JCounter? TteShortname { get; set; }

    public virtual JTourset TteTourset { get; set; } = null!;

    public virtual JTrucktype? TteTrucktype { get; set; }
}
