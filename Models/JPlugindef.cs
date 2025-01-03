using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPlugindef
{
    public decimal PldId { get; set; }

    public decimal? PldConfigdefId { get; set; }

    public DateTime PldTcreation { get; set; }

    public DateTime PldTupdate { get; set; }

    public string PldKey { get; set; } = null!;

    public string? PldDescr { get; set; }

    public string? PldDriver { get; set; }

    public string? PldConfiguration { get; set; }

    public virtual ICollection<JPlugindefpropertyset> JPlugindefpropertysets { get; set; } = new List<JPlugindefpropertyset>();

    public virtual JConfigdef? PldConfigdef { get; set; }
}
