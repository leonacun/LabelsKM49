using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JWorkflowtask
{
    public decimal WftId { get; set; }

    public decimal WftWorkflowId { get; set; }

    public decimal? WftProdstepId { get; set; }

    public DateTime WftTcreation { get; set; }

    public DateTime WftTupdate { get; set; }

    public string WftShortname { get; set; } = null!;

    public string WftProdjobstate { get; set; } = null!;

    public string WftProdjobstrategy { get; set; } = null!;

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual JProdstep? WftProdstep { get; set; }

    public virtual JWorkflow WftWorkflow { get; set; } = null!;
}
