using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAccessrightset
{
    public decimal AcrsId { get; set; }

    public decimal AcrsDefaccesssettingsId { get; set; }

    public DateTime AcrsTcreation { get; set; }

    public DateTime AcrsTupdate { get; set; }

    public string AcrsKey { get; set; } = null!;

    public string AcrsDescr { get; set; } = null!;

    public virtual JAccesssetting AcrsDefaccesssettings { get; set; } = null!;

    public virtual ICollection<JAccessright> JAccessrights { get; set; } = new List<JAccessright>();

    public virtual ICollection<JTool> JTools { get; set; } = new List<JTool>();

    public virtual ICollection<JUserrole> JUserroles { get; set; } = new List<JUserrole>();
}
