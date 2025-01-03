using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPrinterclassmember
{
    public decimal PriclmId { get; set; }

    public decimal PriclmPrinterclassId { get; set; }

    public decimal PriclmPrinterId { get; set; }

    public DateTime PriclmTcreation { get; set; }

    public DateTime PriclmTupdate { get; set; }

    public virtual JPrinter PriclmPrinter { get; set; } = null!;

    public virtual JPrinterclass PriclmPrinterclass { get; set; } = null!;
}
