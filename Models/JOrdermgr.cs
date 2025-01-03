using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrdermgr
{
    public decimal OmId { get; set; }

    public decimal OmContractId { get; set; }

    public decimal? OmConfigdefId { get; set; }

    public DateTime OmTcreation { get; set; }

    public DateTime OmTupdate { get; set; }

    public string OmKey { get; set; } = null!;

    public string OmDescr { get; set; } = null!;

    public virtual ICollection<JOrdereventcfg> JOrdereventcfgs { get; set; } = new List<JOrdereventcfg>();

    public virtual ICollection<JOrdermgrpropertyset> JOrdermgrpropertysets { get; set; } = new List<JOrdermgrpropertyset>();

    public virtual JConfigdef? OmConfigdef { get; set; }

    public virtual JContract OmContract { get; set; } = null!;
}
