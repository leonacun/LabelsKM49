using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPrintlog
{
    public decimal PrilId { get; set; }

    public decimal? PrilTransitionId { get; set; }

    public decimal? PrilPrinterId { get; set; }

    public DateTime PrilTcreation { get; set; }

    public DateTime PrilTupdate { get; set; }

    public decimal PrilObjectid { get; set; }

    public string PrilDoctype { get; set; } = null!;

    public string? PrilDocdefkey { get; set; }

    public byte PrilNrofcopies { get; set; }

    public string? PrilExternalprinterkey { get; set; }

    public string? PrilObjectinfo1 { get; set; }

    public string? PrilObjectinfo2 { get; set; }

    public virtual JPrinter? PrilPrinter { get; set; }

    public virtual JTransition? PrilTransition { get; set; }
}
