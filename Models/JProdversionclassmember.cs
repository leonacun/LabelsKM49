using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdversionclassmember
{
    public decimal PvclmId { get; set; }

    public decimal PvclmProdversionclassId { get; set; }

    public decimal PvclmProdflowusageId { get; set; }

    public DateTime PvclmTcreation { get; set; }

    public DateTime PvclmTupdate { get; set; }

    public virtual JProdflowusage PvclmProdflowusage { get; set; } = null!;

    public virtual JProdversionclass PvclmProdversionclass { get; set; } = null!;
}
