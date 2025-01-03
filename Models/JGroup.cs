using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JGroup
{
    public decimal GId { get; set; }

    public decimal GGroupsetId { get; set; }

    public DateTime GTcreation { get; set; }

    public DateTime GTupdate { get; set; }

    public string GShortname { get; set; } = null!;

    public string GDescr { get; set; } = null!;

    public virtual JGroupset GGroupset { get; set; } = null!;

    public virtual ICollection<JAdvice> JAdvices { get; set; } = new List<JAdvice>();

    public virtual ICollection<JGroupmember> JGroupmembers { get; set; } = new List<JGroupmember>();

    public virtual ICollection<JMessagecfg> JMessagecfgMsgcGroupbccs { get; set; } = new List<JMessagecfg>();

    public virtual ICollection<JMessagecfg> JMessagecfgMsgcGroupccs { get; set; } = new List<JMessagecfg>();

    public virtual ICollection<JMessagecfg> JMessagecfgMsgcGrouptos { get; set; } = new List<JMessagecfg>();

    public virtual ICollection<JStation> JStations { get; set; } = new List<JStation>();

    public virtual ICollection<JTicket> JTickets { get; set; } = new List<JTicket>();

    public virtual ICollection<JUserrole> JUserroles { get; set; } = new List<JUserrole>();
}
