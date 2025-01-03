using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDeliveryinfo
{
    public decimal DliId { get; set; }

    public decimal DliDeliveryId { get; set; }

    public DateTime DliTcreation { get; set; }

    public DateTime DliTupdate { get; set; }

    public string DliType { get; set; } = null!;

    public string? DliKey { get; set; }

    public DateTime? DliTimevalue { get; set; }

    public string? DliStringvalue { get; set; }

    public virtual JDelivery DliDelivery { get; set; } = null!;
}
