using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdversionclass
{
    public decimal PvclId { get; set; }

    public decimal PvclCompanyId { get; set; }

    public DateTime PvclTcreation { get; set; }

    public DateTime PvclTupdate { get; set; }

    public string PvclKey { get; set; } = null!;

    public string PvclDescr { get; set; } = null!;

    public virtual ICollection<JProdversionclassmember> JProdversionclassmembers { get; set; } = new List<JProdversionclassmember>();

    public virtual JCompany PvclCompany { get; set; } = null!;
}
