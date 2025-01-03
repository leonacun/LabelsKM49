using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocktag
{
    public decimal SttId { get; set; }

    public decimal SttStocktagsetId { get; set; }

    public decimal SttSubjectId { get; set; }

    public decimal SttStockId { get; set; }

    public DateTime SttTcreation { get; set; }

    public int SttNo { get; set; }

    public decimal SttAmount { get; set; }

    public bool SttOpen { get; set; }

    public DateTime SttTupdate { get; set; }

    public decimal? SttStockinvId { get; set; }

    public decimal? SttCountedbyuserId { get; set; }

    public virtual JUser? SttCountedbyuser { get; set; }

    public virtual JStock SttStock { get; set; } = null!;

    public virtual JStockinv? SttStockinv { get; set; }

    public virtual JStocktagset SttStocktagset { get; set; } = null!;

    public virtual JSubject SttSubject { get; set; } = null!;
}
