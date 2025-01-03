using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinv
{
    public decimal StiId { get; set; }

    public decimal StiStockId { get; set; }

    public DateTime StiTcreation { get; set; }

    public DateTime StiTupdate { get; set; }

    public string StiState { get; set; } = null!;

    public string StiDescr { get; set; } = null!;

    public DateTime? StiTimestarted { get; set; }

    public DateTime? StiTimeended { get; set; }

    public DateTime? StiTimetagscreated { get; set; }

    public string StiCmd { get; set; } = null!;

    public string StiCmdstate { get; set; } = null!;

    public string? StiLastcmdresult { get; set; }

    public string? StiNo { get; set; }

    public decimal? StiContainersetclassId { get; set; }

    public decimal? StiStockclassId { get; set; }

    public decimal? StiStockinvtypeId { get; set; }

    public decimal? StiStocktagsetId { get; set; }

    public virtual ICollection<JStockinvcontainerset> JStockinvcontainersets { get; set; } = new List<JStockinvcontainerset>();

    public virtual ICollection<JStockinvcresult> JStockinvcresults { get; set; } = new List<JStockinvcresult>();

    public virtual ICollection<JStockinvdiffitem> JStockinvdiffitems { get; set; } = new List<JStockinvdiffitem>();

    public virtual ICollection<JStockinvitem> JStockinvitems { get; set; } = new List<JStockinvitem>();

    public virtual ICollection<JStockinvstockentry> JStockinvstockentries { get; set; } = new List<JStockinvstockentry>();

    public virtual ICollection<JStockinvstockloc> JStockinvstocklocs { get; set; } = new List<JStockinvstockloc>();

    public virtual ICollection<JStocktag> JStocktags { get; set; } = new List<JStocktag>();

    public virtual JContainersetclass? StiContainersetclass { get; set; }

    public virtual JStock StiStock { get; set; } = null!;

    public virtual JStockclass? StiStockclass { get; set; }

    public virtual JStockinvtype? StiStockinvtype { get; set; }

    public virtual JStocktagset? StiStocktagset { get; set; }
}
