using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JObjectcache
{
    public decimal OcaId { get; set; }

    public decimal OcaUserId { get; set; }

    public DateTime OcaTcreation { get; set; }

    public DateTime OcaTupdate { get; set; }

    public string OcaObjectclassname { get; set; } = null!;

    public string? OcaKey1 { get; set; }

    public string? OcaKey2 { get; set; }

    public string? OcaKey3 { get; set; }

    public virtual ICollection<JObjectcacheentry> JObjectcacheentries { get; set; } = new List<JObjectcacheentry>();

    public virtual JUser OcaUser { get; set; } = null!;
}
