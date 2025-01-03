using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPropertyset
{
    public decimal ProsId { get; set; }

    public DateTime ProsTcreation { get; set; }

    public DateTime ProsTupdate { get; set; }

    public string ProsType { get; set; } = null!;

    public string ProsKey { get; set; } = null!;

    public string ProsDescr { get; set; } = null!;

    public DateTime? ProsTimecheckout { get; set; }

    public string? ProsCheckoutdescr { get; set; }

    public string? ProsFilename { get; set; }

    public virtual ICollection<JCompany> JCompanies { get; set; } = new List<JCompany>();

    public virtual ICollection<JComponentdefpropertyset> JComponentdefpropertysets { get; set; } = new List<JComponentdefpropertyset>();

    public virtual ICollection<JDocdefpropertyset> JDocdefpropertysets { get; set; } = new List<JDocdefpropertyset>();

    public virtual ICollection<JEdidefpropertyset> JEdidefpropertysets { get; set; } = new List<JEdidefpropertyset>();

    public virtual ICollection<JOrdermgrpropertyset> JOrdermgrpropertysets { get; set; } = new List<JOrdermgrpropertyset>();

    public virtual ICollection<JPlugindefpropertyset> JPlugindefpropertysets { get; set; } = new List<JPlugindefpropertyset>();

    public virtual ICollection<JProperty> JProperties { get; set; } = new List<JProperty>();

    public virtual ICollection<JServicedefpropertyset> JServicedefpropertysets { get; set; } = new List<JServicedefpropertyset>();

    public virtual ICollection<JServicepropertyset> JServicepropertysets { get; set; } = new List<JServicepropertyset>();

    public virtual ICollection<JTooldefpropertyset> JTooldefpropertysets { get; set; } = new List<JTooldefpropertyset>();

    public virtual ICollection<JToolpropertyset> JToolpropertysets { get; set; } = new List<JToolpropertyset>();
}
