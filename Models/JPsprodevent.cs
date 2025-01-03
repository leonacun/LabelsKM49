using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPsprodevent
{
    public decimal PspreId { get; set; }

    public DateTime PspreTcreation { get; set; }

    public decimal? PspreDeletionid { get; set; }

    public DateTime? PspreTdeletion { get; set; }

    public string PspreSourcesystemkey { get; set; } = null!;

    public string? PspreProdjobnoraw { get; set; }

    public string PspreMachinekey { get; set; } = null!;

    public string? PspreUserkey { get; set; }

    public string PspreSourceid { get; set; } = null!;

    public DateTime PspreSourcetimecreated { get; set; }

    public string PspreQualityclass { get; set; } = null!;

    public string? PspreInfo1 { get; set; }

    public string? PspreInfo2 { get; set; }

    public virtual ICollection<JPsprodeventdatum> JPsprodeventdata { get; set; } = new List<JPsprodeventdatum>();
}
