using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JScriptdef
{
    public decimal ScrdId { get; set; }

    public DateTime ScrdTcreation { get; set; }

    public DateTime ScrdTupdate { get; set; }

    public string ScrdKey { get; set; } = null!;

    public string? ScrdDescr { get; set; }

    public string? ScrdFilename { get; set; }

    public string ScrdLanguage { get; set; } = null!;

    public virtual ICollection<JContainerset> JContainersets { get; set; } = new List<JContainerset>();

    public virtual ICollection<JTour> JTours { get; set; } = new List<JTour>();

    public virtual ICollection<JTourtemplate> JTourtemplates { get; set; } = new List<JTourtemplate>();
}
