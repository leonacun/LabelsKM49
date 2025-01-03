using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDeliveryentry
{
    public decimal DleId { get; set; }

    public decimal DleDeliveryId { get; set; }

    public decimal DleContractId { get; set; }

    public DateTime DleTcreation { get; set; }

    public string DleNo { get; set; } = null!;

    public string? DleKeyincontract { get; set; }

    public string DleDescriptortype { get; set; } = null!;

    public virtual JContract DleContract { get; set; } = null!;

    public virtual JDelivery DleDelivery { get; set; } = null!;

    public virtual ICollection<JDeliverynote> JDeliverynotes { get; set; } = new List<JDeliverynote>();
}
