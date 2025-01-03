using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdstepclassmember
{
    public decimal PrsclmId { get; set; }

    public decimal PrsclmProdstepclassId { get; set; }

    public decimal PrsclmProdstepId { get; set; }

    public DateTime PrsclmTcreation { get; set; }

    public DateTime PrsclmTupdate { get; set; }

    public virtual JProdstep PrsclmProdstep { get; set; } = null!;

    public virtual JProdstepclass PrsclmProdstepclass { get; set; } = null!;
}
