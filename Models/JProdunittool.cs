using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunittool
{
    public decimal PutId { get; set; }

    public decimal PutProdunitId { get; set; }

    public decimal PutProdtoolId { get; set; }

    public DateTime PutTcreation { get; set; }

    public DateTime PutTupdate { get; set; }

    public decimal PutMincycletimeinsec { get; set; }

    public decimal PutSetuptimeinsec { get; set; }

    public decimal PutTeardowntimeinsec { get; set; }

    public virtual ICollection<JProdunittoolinfo> JProdunittoolinfos { get; set; } = new List<JProdunittoolinfo>();

    public virtual JProdtool PutProdtool { get; set; } = null!;

    public virtual JProdunit PutProdunit { get; set; } = null!;
}
