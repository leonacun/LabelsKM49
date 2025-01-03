using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplan
{
    public decimal PplId { get; set; }

    public decimal PplProdplansetId { get; set; }

    public decimal? PplContractId { get; set; }

    public decimal? PplProdplantypeId { get; set; }

    public decimal? PplProdunitId { get; set; }

    public DateTime PplTcreation { get; set; }

    public DateTime PplTupdate { get; set; }

    public string? PplKey { get; set; }

    public string? PplShortname { get; set; }

    public string? PplDescr { get; set; }

    public DateTime? PplScheduledtime { get; set; }

    public string PplState { get; set; } = null!;

    public string PplEditor { get; set; } = null!;

    public virtual ICollection<JContainerset> JContainersets { get; set; } = new List<JContainerset>();

    public virtual ICollection<JProdplanentry> JProdplanentries { get; set; } = new List<JProdplanentry>();

    public virtual JContract? PplContract { get; set; }

    public virtual JProdplanset PplProdplanset { get; set; } = null!;

    public virtual JProdplantype? PplProdplantype { get; set; }

    public virtual JProdunit? PplProdunit { get; set; }
}
