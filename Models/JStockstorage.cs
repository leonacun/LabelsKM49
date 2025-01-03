using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockstorage
{
    public decimal StsId { get; set; }

    public decimal StsStockId { get; set; }

    public DateTime StsTcreation { get; set; }

    public DateTime StsTupdate { get; set; }

    public string StsKind { get; set; } = null!;

    public string? StsDescr { get; set; }

    public int StsWidth { get; set; }

    public int StsHeight { get; set; }

    public int StsDepth { get; set; }

    public int StsPosx { get; set; }

    public int StsPosy { get; set; }

    public decimal StsRotation { get; set; }

    public virtual ICollection<JStockstorageelem> JStockstorageelems { get; set; } = new List<JStockstorageelem>();

    public virtual ICollection<JStockstoragepoint> JStockstoragepoints { get; set; } = new List<JStockstoragepoint>();

    public virtual JStock StsStock { get; set; } = null!;
}
