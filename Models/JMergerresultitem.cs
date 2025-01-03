using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMergerresultitem
{
    public decimal MriId { get; set; }

    public decimal MriMergerresultId { get; set; }

    public DateTime MriTcreation { get; set; }

    public DateTime MriTupdate { get; set; }

    public string MriKind { get; set; } = null!;

    public string? MriKey1 { get; set; }

    public string? MriKey2 { get; set; }

    public string? MriDescr { get; set; }

    public string? MriAction { get; set; }

    public string? MriValueold { get; set; }

    public string? MriValuenew { get; set; }

    public virtual JMergerresult MriMergerresult { get; set; } = null!;
}
