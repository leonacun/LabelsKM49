using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMergerresult
{
    public decimal MrId { get; set; }

    public DateTime MrTcreation { get; set; }

    public DateTime MrTupdate { get; set; }

    public string MrKey { get; set; } = null!;

    public string MrType { get; set; } = null!;

    public string MrDescr { get; set; } = null!;

    public decimal? MrDeletionid { get; set; }

    public DateTime? MrTdeletion { get; set; }

    public string? MrErrormessage { get; set; }

    public virtual ICollection<JMergerresultitem> JMergerresultitems { get; set; } = new List<JMergerresultitem>();
}
