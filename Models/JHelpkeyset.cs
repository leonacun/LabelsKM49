using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JHelpkeyset
{
    public decimal HksId { get; set; }

    public DateTime HksTcreation { get; set; }

    public DateTime HksTupdate { get; set; }

    public string HksKey { get; set; } = null!;

    public string HksDescr { get; set; } = null!;

    public virtual ICollection<JHelpkey> JHelpkeys { get; set; } = new List<JHelpkey>();
}
