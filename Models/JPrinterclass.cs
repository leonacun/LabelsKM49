using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPrinterclass
{
    public decimal PriclId { get; set; }

    public DateTime PriclTcreation { get; set; }

    public DateTime PriclTupdate { get; set; }

    public string PriclKey { get; set; } = null!;

    public string PriclDescr { get; set; } = null!;

    public virtual ICollection<JPrinterclassmember> JPrinterclassmembers { get; set; } = new List<JPrinterclassmember>();

    public virtual ICollection<JPrintitem> JPrintitems { get; set; } = new List<JPrintitem>();
}
