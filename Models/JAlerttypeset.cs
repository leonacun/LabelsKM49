using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAlerttypeset
{
    public decimal AltsId { get; set; }

    public DateTime AltsTcreation { get; set; }

    public DateTime AltsTupdate { get; set; }

    public string AltsKey { get; set; } = null!;

    public string AltsDescr { get; set; } = null!;

    public virtual ICollection<JAlerttype> JAlerttypes { get; set; } = new List<JAlerttype>();
}
