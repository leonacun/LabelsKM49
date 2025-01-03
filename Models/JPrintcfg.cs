using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPrintcfg
{
    public decimal PricId { get; set; }

    public decimal PricPrintcfgsetId { get; set; }

    public decimal? PricPrinterId { get; set; }

    public decimal? PricPrintitemId { get; set; }

    public DateTime PricTcreation { get; set; }

    public DateTime PricTupdate { get; set; }

    public string PricToolpattern { get; set; } = null!;

    public string PricUserpattern { get; set; } = null!;

    public string PricWorkstationpattern { get; set; } = null!;

    public string PricPfpattern { get; set; } = null!;

    public string PricHintpattern { get; set; } = null!;

    public byte PricNrofcopies { get; set; }

    public string? PricExternalprinterkey { get; set; }

    public virtual JPrintcfgset PricPrintcfgset { get; set; } = null!;

    public virtual JPrinter? PricPrinter { get; set; }

    public virtual JPrintitem? PricPrintitem { get; set; }
}
