using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitclassmember
{
    public decimal PuclmId { get; set; }

    public decimal PuclmProdunitclassId { get; set; }

    public decimal PuclmProdunitId { get; set; }

    public DateTime PuclmTcreation { get; set; }

    public DateTime PuclmTupdate { get; set; }

    public virtual JProdunit PuclmProdunit { get; set; } = null!;

    public virtual JProdunitclass PuclmProdunitclass { get; set; } = null!;
}
