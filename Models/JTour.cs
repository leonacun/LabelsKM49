using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTour
{
    public decimal TId { get; set; }

    public decimal TToursetId { get; set; }

    public decimal TTrucktypeId { get; set; }

    public decimal? TUserId { get; set; }

    public decimal? TCarrierId { get; set; }

    public decimal? TBorderocounterId { get; set; }

    public decimal? TDeliveryId { get; set; }

    public DateTime TTcreation { get; set; }

    public DateTime TTupdate { get; set; }

    public string TShortname { get; set; } = null!;

    public string? TAltname { get; set; }

    public string? TDescr { get; set; }

    public string TStatus { get; set; } = null!;

    public bool TDayofweek { get; set; }

    public DateTime TDeparturetime { get; set; }

    public DateTime TArrivaltime { get; set; }

    public byte TLoadingadvinminutes { get; set; }

    public DateTime? TTimeverified { get; set; }

    public DateTime? TTimecompleted { get; set; }

    public DateTime? TTimeprinted { get; set; }

    public DateTime? TTimeplanned { get; set; }

    public DateTime? TTimetransport { get; set; }

    public string TTransportmedia { get; set; } = null!;

    public DateTime? TTimestaged { get; set; }

    public DateTime? TTimeestimatedarrival { get; set; }

    public byte TTransportinminutes { get; set; }

    public decimal? TScriptdefId { get; set; }

    public int TLoadsizex { get; set; }

    public int TLoadsizey { get; set; }

    public int TLoadsizez { get; set; }

    public decimal? TPlanneddeliveryId { get; set; }

    public string TDeliveryplanningtype { get; set; } = null!;

    public DateTime? TTimearrived { get; set; }

    public virtual ICollection<JLoadplanentry> JLoadplanentries { get; set; } = new List<JLoadplanentry>();

    public virtual ICollection<JTourcontainer> JTourcontainers { get; set; } = new List<JTourcontainer>();

    public virtual ICollection<JTourinfo> JTourinfos { get; set; } = new List<JTourinfo>();

    public virtual JCounter? TBorderocounter { get; set; }

    public virtual JCompany? TCarrier { get; set; }

    public virtual JDelivery? TDelivery { get; set; }

    public virtual JDelivery? TPlanneddelivery { get; set; }

    public virtual JScriptdef? TScriptdef { get; set; }

    public virtual JTourset TTourset { get; set; } = null!;

    public virtual JTrucktype TTrucktype { get; set; } = null!;

    public virtual JUser? TUser { get; set; }
}
