using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintarea
{
    public decimal PaaId { get; set; }

    public decimal PaaPaintunitId { get; set; }

    public DateTime PaaTcreation { get; set; }

    public DateTime PaaTupdate { get; set; }

    public string PaaDescr { get; set; } = null!;

    public bool PaaCode { get; set; }

    public virtual ICollection<JSkidtype> JSkidtypes { get; set; } = new List<JSkidtype>();

    public virtual JPaintunit PaaPaintunit { get; set; } = null!;
}
