using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdeventset
{
    public decimal PresId { get; set; }

    public decimal PresCompanyId { get; set; }

    public DateTime PresTcreation { get; set; }

    public DateTime PresTupdate { get; set; }

    public string PresKey { get; set; } = null!;

    public string PresDescr { get; set; } = null!;

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual JCompany PresCompany { get; set; } = null!;
}
