using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLocation
{
    public decimal LId { get; set; }

    public decimal LCompanyId { get; set; }

    public decimal? LAddressId { get; set; }

    public DateTime LTcreation { get; set; }

    public DateTime LTupdate { get; set; }

    public string? LKey { get; set; }

    public string? LDescr { get; set; }

    public string LType { get; set; } = null!;

    public string? LSite { get; set; }

    public string LLoadingpoint { get; set; } = null!;

    public string? LUsagepoint { get; set; }

    public virtual ICollection<JContainermapcfg> JContainermapcfgs { get; set; } = new List<JContainermapcfg>();

    public virtual ICollection<JContainer> JContainers { get; set; } = new List<JContainer>();

    public virtual ICollection<JContainersetloc> JContainersetlocs { get; set; } = new List<JContainersetloc>();

    public virtual ICollection<JContractcumulative> JContractcumulatives { get; set; } = new List<JContractcumulative>();

    public virtual ICollection<JContractentry> JContractentries { get; set; } = new List<JContractentry>();

    public virtual ICollection<JDeliverynote> JDeliverynotes { get; set; } = new List<JDeliverynote>();

    public virtual ICollection<JLocationclassmember> JLocationclassmembers { get; set; } = new List<JLocationclassmember>();

    public virtual ICollection<JLocationinfo> JLocationinfoLiLocations { get; set; } = new List<JLocationinfo>();

    public virtual ICollection<JLocationinfo> JLocationinfoLiReflocations { get; set; } = new List<JLocationinfo>();

    public virtual ICollection<JOrderentry> JOrderentries { get; set; } = new List<JOrderentry>();

    public virtual ICollection<JOrderevententry> JOrderevententries { get; set; } = new List<JOrderevententry>();

    public virtual ICollection<JProdplanentryelem> JProdplanentryelems { get; set; } = new List<JProdplanentryelem>();

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JSupplynote> JSupplynotes { get; set; } = new List<JSupplynote>();

    public virtual ICollection<JTourcontainer> JTourcontainers { get; set; } = new List<JTourcontainer>();

    public virtual JAddress? LAddress { get; set; }

    public virtual JCompany LCompany { get; set; } = null!;
}
