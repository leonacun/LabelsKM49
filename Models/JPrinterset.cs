using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPrinterset
{
    public decimal PrisId { get; set; }

    public DateTime PrisTcreation { get; set; }

    public DateTime PrisTupdate { get; set; }

    public string PrisKey { get; set; } = null!;

    public string PrisDescr { get; set; } = null!;

    public virtual ICollection<JPrinter> JPrinters { get; set; } = new List<JPrinter>();
}
