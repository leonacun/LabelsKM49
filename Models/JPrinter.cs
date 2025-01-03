using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPrinter
{
    public decimal PriId { get; set; }

    public decimal PriPrintersetId { get; set; }

    public decimal? PriRedirprinterId { get; set; }

    public DateTime PriTcreation { get; set; }

    public DateTime PriTupdate { get; set; }

    public string PriKey { get; set; } = null!;

    public string PriDescr { get; set; } = null!;

    public string PriProtocol { get; set; } = null!;

    public string? PriDialect { get; set; }

    public string PriConfig { get; set; } = null!;

    public string PriTemplate { get; set; } = null!;

    public bool PriIseditable { get; set; }

    public string? PriOsqueue { get; set; }

    public string? PriUrl { get; set; }

    public virtual ICollection<JPrinter> InversePriRedirprinter { get; set; } = new List<JPrinter>();

    public virtual ICollection<JMessagecfg> JMessagecfgs { get; set; } = new List<JMessagecfg>();

    public virtual ICollection<JPrintcfg> JPrintcfgs { get; set; } = new List<JPrintcfg>();

    public virtual ICollection<JPrinterclassmember> JPrinterclassmembers { get; set; } = new List<JPrinterclassmember>();

    public virtual ICollection<JPrintlog> JPrintlogs { get; set; } = new List<JPrintlog>();

    public virtual JPrinterset PriPrinterset { get; set; } = null!;

    public virtual JPrinter? PriRedirprinter { get; set; }
}
