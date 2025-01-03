using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockstorageelem
{
    public decimal StseId { get; set; }

    public decimal StseStockstorageId { get; set; }

    public DateTime StseTcreation { get; set; }

    public DateTime StseTupdate { get; set; }

    public string? StseDescr { get; set; }

    public int StseColumnwidth { get; set; }

    public int StseRowheight { get; set; }

    public byte StseColumns { get; set; }

    public byte StseRows { get; set; }

    public int StsePosx { get; set; }

    public int StsePosy { get; set; }

    public int StseSepx { get; set; }

    public virtual ICollection<JStockstorageelemloc> JStockstorageelemlocs { get; set; } = new List<JStockstorageelemloc>();

    public virtual JStockstorage StseStockstorage { get; set; } = null!;
}
