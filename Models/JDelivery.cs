using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDelivery
{
    public decimal DlId { get; set; }

    public decimal DlCompanyId { get; set; }

    public decimal? DlCarrierId { get; set; }

    public decimal? DlDoccfgId { get; set; }

    public DateTime DlTcreation { get; set; }

    public string DlTransporttype { get; set; } = null!;

    public string DlTransportmedia { get; set; } = null!;

    public DateTime? DlTransporttime { get; set; }

    public DateTime? DlTimedelivered { get; set; }

    public bool DlOpen { get; set; }

    public DateTime? DlEstimatedarrivaltime { get; set; }

    public string DlDescriptortype { get; set; } = null!;

    public virtual JCompany? DlCarrier { get; set; }

    public virtual JCompany DlCompany { get; set; } = null!;

    public virtual JDoccfg? DlDoccfg { get; set; }

    public virtual ICollection<JDeliveryentry> JDeliveryentries { get; set; } = new List<JDeliveryentry>();

    public virtual ICollection<JDeliveryinfo> JDeliveryinfos { get; set; } = new List<JDeliveryinfo>();

    public virtual ICollection<JTour> JTourTDeliveries { get; set; } = new List<JTour>();

    public virtual ICollection<JTour> JTourTPlanneddeliveries { get; set; } = new List<JTour>();
}
