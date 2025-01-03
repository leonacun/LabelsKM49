using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMeasurementset
{
    public decimal MesId { get; set; }

    public decimal MesCompanyId { get; set; }

    public DateTime MesTcreation { get; set; }

    public DateTime MesTupdate { get; set; }

    public string MesKey { get; set; } = null!;

    public string MesDescr { get; set; } = null!;

    public virtual ICollection<JMeasurement> JMeasurements { get; set; } = new List<JMeasurement>();

    public virtual JCompany MesCompany { get; set; } = null!;
}
