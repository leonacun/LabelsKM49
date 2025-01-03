using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JEdidef
{
    public decimal EdId { get; set; }

    public decimal EdCompanyId { get; set; }

    public decimal? EdConfigdefId { get; set; }

    public DateTime EdTcreation { get; set; }

    public DateTime EdTupdate { get; set; }

    public string EdKey { get; set; } = null!;

    public string EdEditype { get; set; } = null!;

    public string? EdDescr { get; set; }

    public string? EdDriver { get; set; }

    public string? EdTemplate { get; set; }

    public string? EdParams { get; set; }

    public string? EdConfiguration { get; set; }

    public decimal? EdConnectionId { get; set; }

    public virtual JCompany EdCompany { get; set; } = null!;

    public virtual JConfigdef? EdConfigdef { get; set; }

    public virtual JTransferconnection? EdConnection { get; set; }

    public virtual ICollection<JEdicfgitem> JEdicfgitems { get; set; } = new List<JEdicfgitem>();

    public virtual ICollection<JEdidefpropertyset> JEdidefpropertysets { get; set; } = new List<JEdidefpropertyset>();
}
