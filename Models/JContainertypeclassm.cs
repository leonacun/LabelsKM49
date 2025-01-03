using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainertypeclassm
{
    public decimal CttcmId { get; set; }

    public decimal CttcmContainertypeclassId { get; set; }

    public decimal CttcmContainertypeId { get; set; }

    public DateTime CttcmTcreation { get; set; }

    public DateTime CttcmTupdate { get; set; }

    public virtual JContainertype CttcmContainertype { get; set; } = null!;

    public virtual JContainertypeclass CttcmContainertypeclass { get; set; } = null!;
}
