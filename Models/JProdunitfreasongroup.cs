using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitfreasongroup
{
    public decimal PufrgId { get; set; }

    public decimal PufrgProdunitId { get; set; }

    public decimal PufrgFreasongroupId { get; set; }

    public DateTime PufrgTcreation { get; set; }

    public DateTime PufrgTupdate { get; set; }

    public string PufrgRole { get; set; } = null!;

    public virtual JFreasongroup PufrgFreasongroup { get; set; } = null!;

    public virtual JProdunit PufrgProdunit { get; set; } = null!;
}
