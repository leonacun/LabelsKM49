using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransfermessage
{
    public decimal TmId { get; set; }

    public decimal TmRecordId { get; set; }

    public DateTime TmTcreation { get; set; }

    public string? TmText { get; set; }

    public virtual JTransferrecord TmRecord { get; set; } = null!;
}
