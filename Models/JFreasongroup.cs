using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFreasongroup
{
    public decimal FrgId { get; set; }

    public decimal FrgCompanyId { get; set; }

    public decimal? FrgFreasonsetId { get; set; }

    public DateTime FrgTcreation { get; set; }

    public DateTime FrgTupdate { get; set; }

    public decimal? FrgInvalidid { get; set; }

    public DateTime? FrgTvalidfrom { get; set; }

    public DateTime? FrgTvaliduntil { get; set; }

    public string FrgKey { get; set; } = null!;

    public string FrgDescr { get; set; } = null!;

    public bool FrgHoldsreasons { get; set; }

    public bool FrgHoldsgroups { get; set; }

    public virtual JCompany FrgCompany { get; set; } = null!;

    public virtual JFailurereasonset? FrgFreasonset { get; set; }

    public virtual ICollection<JFreasongroupgmember> JFreasongroupgmemberFrggmFreasongroups { get; set; } = new List<JFreasongroupgmember>();

    public virtual ICollection<JFreasongroupgmember> JFreasongroupgmemberFrggmMemberfreasongroups { get; set; } = new List<JFreasongroupgmember>();

    public virtual ICollection<JFreasongroupmember> JFreasongroupmembers { get; set; } = new List<JFreasongroupmember>();

    public virtual ICollection<JProduniteventdatum> JProduniteventdata { get; set; } = new List<JProduniteventdatum>();

    public virtual ICollection<JProdunitfreasongroup> JProdunitfreasongroups { get; set; } = new List<JProdunitfreasongroup>();

    public virtual ICollection<JProdunitintervalinfo> JProdunitintervalinfos { get; set; } = new List<JProdunitintervalinfo>();
}
