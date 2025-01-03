using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAccesssetting
{
    public decimal AcsId { get; set; }

    public DateTime AcsTcreation { get; set; }

    public DateTime AcsTupdate { get; set; }

    public string AcsCode { get; set; } = null!;

    public string AcsDescr { get; set; } = null!;

    public bool? AcsIseditable { get; set; }

    public bool AcsOpview { get; set; }

    public bool AcsOpedit { get; set; }

    public bool AcsOpoperation { get; set; }

    public bool AcsOpcreate { get; set; }

    public bool AcsOpdelete { get; set; }

    public virtual ICollection<JAccessright> JAccessrights { get; set; } = new List<JAccessright>();

    public virtual ICollection<JAccessrightset> JAccessrightsets { get; set; } = new List<JAccessrightset>();
}
