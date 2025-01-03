using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JServicedef
{
    public decimal SvcdId { get; set; }

    public decimal SvcdServerId { get; set; }

    public decimal? SvcdConfigdefId { get; set; }

    public DateTime SvcdTcreation { get; set; }

    public DateTime SvcdTupdate { get; set; }

    public string SvcdKey { get; set; } = null!;

    public string SvcdName { get; set; } = null!;

    public string? SvcdDescr { get; set; }

    public string? SvcdDriver { get; set; }

    public virtual ICollection<JServicedefpropertyset> JServicedefpropertysets { get; set; } = new List<JServicedefpropertyset>();

    public virtual ICollection<JService> JServices { get; set; } = new List<JService>();

    public virtual JConfigdef? SvcdConfigdef { get; set; }

    public virtual JServer SvcdServer { get; set; } = null!;
}
