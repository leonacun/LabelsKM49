using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransition
{
    public decimal TrsId { get; set; }

    public decimal TrsTransitionsetId { get; set; }

    public decimal TrsTranstypeId { get; set; }

    public decimal TrsSessionId { get; set; }

    public DateTime TrsTcreation { get; set; }

    public string TrsDescr { get; set; } = null!;

    public string? TrsInfo1 { get; set; }

    public string? TrsInfo2 { get; set; }

    public virtual ICollection<JContainerevent> JContainerevents { get; set; } = new List<JContainerevent>();

    public virtual ICollection<JContractcumulative> JContractcumulatives { get; set; } = new List<JContractcumulative>();

    public virtual ICollection<JLogentry> JLogentries { get; set; } = new List<JLogentry>();

    public virtual ICollection<JObjectlog> JObjectlogs { get; set; } = new List<JObjectlog>();

    public virtual ICollection<JOrderevent> JOrderevents { get; set; } = new List<JOrderevent>();

    public virtual ICollection<JPartevent> JPartevents { get; set; } = new List<JPartevent>();

    public virtual ICollection<JPrintlog> JPrintlogs { get; set; } = new List<JPrintlog>();

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual ICollection<JProdunitevent> JProdunitevents { get; set; } = new List<JProdunitevent>();

    public virtual ICollection<JServerlog> JServerlogs { get; set; } = new List<JServerlog>();

    public virtual ICollection<JSkidevent> JSkidevents { get; set; } = new List<JSkidevent>();

    public virtual ICollection<JStockevent> JStockevents { get; set; } = new List<JStockevent>();

    public virtual ICollection<JStockinvstockloc> JStockinvstocklocs { get; set; } = new List<JStockinvstockloc>();

    public virtual ICollection<JStocksubstevent> JStocksubstevents { get; set; } = new List<JStocksubstevent>();

    public virtual ICollection<JTransitioninfo> JTransitioninfos { get; set; } = new List<JTransitioninfo>();

    public virtual ICollection<JUserqualificationevent> JUserqualificationevents { get; set; } = new List<JUserqualificationevent>();

    public virtual JSession TrsSession { get; set; } = null!;

    public virtual JTransitionset TrsTransitionset { get; set; } = null!;

    public virtual JTransitiontype TrsTranstype { get; set; } = null!;
}
