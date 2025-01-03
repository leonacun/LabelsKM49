using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvssboxdatum
{
    public decimal PvbdId { get; set; }

    public decimal PvbdPvssId { get; set; }

    public decimal? PvbdProdunitId { get; set; }

    public DateTime PvbdTcreation { get; set; }

    public DateTime PvbdTupdate { get; set; }

    public DateTime? PvbdTimereceived { get; set; }

    public DateTime? PvbdTimesendrequest { get; set; }

    public DateTime? PvbdTimesent { get; set; }

    public string? PvbdSenderrormessage { get; set; }

    public string? PvbdStationcode { get; set; }

    public string PvbdNo { get; set; } = null!;

    public string PvbdBoxtype { get; set; } = null!;

    public string? PvbdTypecode1 { get; set; }

    public string? PvbdColorcode1 { get; set; }

    public short PvbdQuantity1 { get; set; }

    public string? PvbdTypecode2 { get; set; }

    public string? PvbdColorcode2 { get; set; }

    public short PvbdQuantity2 { get; set; }

    public string? PvbdPaintno { get; set; }

    public string? PvbdPaintplanno { get; set; }

    public short PvbdPaintplanpos { get; set; }

    public short PvbdPaintplansubpos { get; set; }

    public virtual JProdunit? PvbdProdunit { get; set; }

    public virtual JPvss PvbdPvss { get; set; } = null!;
}
