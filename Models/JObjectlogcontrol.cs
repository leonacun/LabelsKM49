using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JObjectlogcontrol
{
    public decimal OlcId { get; set; }

    public DateTime OlcTcreation { get; set; }

    public string OlcObjectclassname { get; set; } = null!;

    public bool? OlcEnabled { get; set; }

    public string? OlcLogclassname { get; set; }

    public string? OlcLogattributeclassname { get; set; }

    public bool? OlcPrivatelog { get; set; }

    public DateTime OlcTupdate { get; set; }
}
