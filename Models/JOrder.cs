using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrder
{
    public decimal OId { get; set; }

    public decimal OContractId { get; set; }

    public decimal? OReforderId { get; set; }

    public DateTime OTcreation { get; set; }

    public DateTime OTupdate { get; set; }

    public string ONo { get; set; } = null!;

    public string OVersion { get; set; } = null!;

    public string OType { get; set; } = null!;

    public DateTime? OClosedtimestamp { get; set; }

    public string ORequestor { get; set; } = null!;

    public string? OSequenceno { get; set; }

    public string? OProdsequenceno { get; set; }

    public string? OProductid { get; set; }

    public DateTime? OScheduledtime { get; set; }

    public virtual ICollection<JOrder> InverseOReforder { get; set; } = new List<JOrder>();

    public virtual ICollection<JContainerevent> JContainerevents { get; set; } = new List<JContainerevent>();

    public virtual ICollection<JContainer> JContainers { get; set; } = new List<JContainer>();

    public virtual ICollection<JContractcumulative> JContractcumulatives { get; set; } = new List<JContractcumulative>();

    public virtual ICollection<JContractentry> JContractentries { get; set; } = new List<JContractentry>();

    public virtual ICollection<JDeliverynoteentry> JDeliverynoteentries { get; set; } = new List<JDeliverynoteentry>();

    public virtual ICollection<JDeliverynoteorder> JDeliverynoteorders { get; set; } = new List<JDeliverynoteorder>();

    public virtual ICollection<JDemand> JDemands { get; set; } = new List<JDemand>();

    public virtual ICollection<JOrderbufferentry> JOrderbufferentries { get; set; } = new List<JOrderbufferentry>();

    public virtual ICollection<JOrdercontrolresultitem> JOrdercontrolresultitems { get; set; } = new List<JOrdercontrolresultitem>();

    public virtual ICollection<JOrderentry> JOrderentryOeContractorders { get; set; } = new List<JOrderentry>();

    public virtual ICollection<JOrderentry> JOrderentryOeOrders { get; set; } = new List<JOrderentry>();

    public virtual ICollection<JOrderevent> JOrderevents { get; set; } = new List<JOrderevent>();

    public virtual ICollection<JOrderinfo> JOrderinfos { get; set; } = new List<JOrderinfo>();

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual ICollection<JProdplanentry> JProdplanentries { get; set; } = new List<JProdplanentry>();

    public virtual ICollection<JProdplanentryelem> JProdplanentryelems { get; set; } = new List<JProdplanentryelem>();

    public virtual ICollection<JSchedulerelease> JSchedulereleases { get; set; } = new List<JSchedulerelease>();

    public virtual ICollection<JStockcomponent> JStockcomponents { get; set; } = new List<JStockcomponent>();

    public virtual ICollection<JSupplynoteentry> JSupplynoteentries { get; set; } = new List<JSupplynoteentry>();

    public virtual ICollection<JWorktime> JWorktimes { get; set; } = new List<JWorktime>();

    public virtual JContract OContract { get; set; } = null!;

    public virtual JOrder? OReforder { get; set; }
}
