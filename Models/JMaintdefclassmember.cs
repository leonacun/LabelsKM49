using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintdefclassmember
{
    public decimal MadclmId { get; set; }

    public decimal MadclmMaintdefclassId { get; set; }

    public decimal MadclmMaintdefId { get; set; }

    public DateTime MadclmTcreation { get; set; }

    public DateTime MadclmTupdate { get; set; }

    public virtual JMaintdef MadclmMaintdef { get; set; } = null!;

    public virtual JMaintdefclass MadclmMaintdefclass { get; set; } = null!;
}
