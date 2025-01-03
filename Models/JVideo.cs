using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JVideo
{
    public decimal ViId { get; set; }

    public decimal ViVideosetId { get; set; }

    public DateTime ViTcreation { get; set; }

    public DateTime ViTupdate { get; set; }

    public decimal? ViDeletionid { get; set; }

    public DateTime? ViTdeletion { get; set; }

    public string? ViKey { get; set; }

    public string? ViDescr { get; set; }

    public string? ViFilename { get; set; }

    public string? ViEncoding { get; set; }

    public int ViDatasize { get; set; }

    public byte[] ViData { get; set; } = null!;

    public virtual JVideoset ViVideoset { get; set; } = null!;
}
