using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdflow
{
    public decimal PflId { get; set; }

    public decimal PflProdflowsetId { get; set; }

    public DateTime PflTcreation { get; set; }

    public DateTime PflTupdate { get; set; }

    public string PflCode { get; set; } = null!;

    public string? PflKey { get; set; }

    public string PflDescr { get; set; } = null!;

    public virtual ICollection<JProdflowaction> JProdflowactions { get; set; } = new List<JProdflowaction>();

    public virtual ICollection<JProdflowusage> JProdflowusages { get; set; } = new List<JProdflowusage>();

    public virtual JProdflowset PflProdflowset { get; set; } = null!;
}
