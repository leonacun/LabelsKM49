using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvssareaprodunit
{
    public decimal PvapuId { get; set; }

    public decimal PvapuPvssareaId { get; set; }

    public decimal PvapuProdunitId { get; set; }

    public decimal? PvapuSubjectclassId { get; set; }

    public DateTime PvapuTcreation { get; set; }

    public DateTime PvapuTupdate { get; set; }

    public virtual JProdunit PvapuProdunit { get; set; } = null!;

    public virtual JPvssarea PvapuPvssarea { get; set; } = null!;

    public virtual JSubjectclass? PvapuSubjectclass { get; set; }
}
