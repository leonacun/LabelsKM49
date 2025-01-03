using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdtoolclassmember
{
    public decimal PtclmId { get; set; }

    public decimal PtclmProdtoolclassId { get; set; }

    public decimal PtclmProdtoolId { get; set; }

    public DateTime PtclmTcreation { get; set; }

    public DateTime PtclmTupdate { get; set; }

    public virtual JProdtool PtclmProdtool { get; set; } = null!;

    public virtual JProdtoolclass PtclmProdtoolclass { get; set; } = null!;
}
