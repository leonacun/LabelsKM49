using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintdef
{
    public decimal MadId { get; set; }

    public decimal MadMaintdefsetId { get; set; }

    public decimal? MadProdunitclassId { get; set; }

    public DateTime MadTcreation { get; set; }

    public DateTime MadTupdate { get; set; }

    public string MadKey { get; set; } = null!;

    public string MadDescr { get; set; } = null!;

    public int MadEstdurationinmin { get; set; }

    public decimal? MadProdtoolclassId { get; set; }

    public string MadType { get; set; } = null!;

    public bool? MadComputeestduration { get; set; }

    public virtual ICollection<JMaintdefclassmember> JMaintdefclassmembers { get; set; } = new List<JMaintdefclassmember>();

    public virtual ICollection<JMaintdefcond> JMaintdefconds { get; set; } = new List<JMaintdefcond>();

    public virtual ICollection<JMaintdefinstr> JMaintdefinstrs { get; set; } = new List<JMaintdefinstr>();

    public virtual ICollection<JMaintdefmaterial> JMaintdefmaterials { get; set; } = new List<JMaintdefmaterial>();

    public virtual ICollection<JMaintdefprodtool> JMaintdefprodtools { get; set; } = new List<JMaintdefprodtool>();

    public virtual ICollection<JMaintdefprodunit> JMaintdefprodunits { get; set; } = new List<JMaintdefprodunit>();

    public virtual ICollection<JMaintjob> JMaintjobs { get; set; } = new List<JMaintjob>();

    public virtual JMaintdefset MadMaintdefset { get; set; } = null!;

    public virtual JProdtoolclass? MadProdtoolclass { get; set; }

    public virtual JProdunitclass? MadProdunitclass { get; set; }
}
