using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdflowaction
{
    public decimal PflaId { get; set; }

    public decimal PflaProdflowId { get; set; }

    public decimal? PflaProdstepId { get; set; }

    public decimal? PflaProdunitId { get; set; }

    public DateTime PflaTcreation { get; set; }

    public string PflaCode { get; set; } = null!;

    public string? PflaDescr { get; set; }

    public string? PflaErpcode { get; set; }

    public bool PflaIspaypoint { get; set; }

    public string? PflaErpprodunitcode { get; set; }

    public string? PflaErpprodstepcode { get; set; }

    public virtual JProdflow PflaProdflow { get; set; } = null!;

    public virtual JProdstep? PflaProdstep { get; set; }

    public virtual JProdunit? PflaProdunit { get; set; }
}
