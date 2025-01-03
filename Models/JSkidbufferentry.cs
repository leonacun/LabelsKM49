using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidbufferentry
{
    public decimal SkbeId { get; set; }

    public decimal SkbeSkidbufferId { get; set; }

    public decimal SkbeSkidId { get; set; }

    public DateTime SkbeTcreation { get; set; }

    public DateTime SkbeTupdate { get; set; }

    public virtual JSkid SkbeSkid { get; set; } = null!;

    public virtual JSkidbuffer SkbeSkidbuffer { get; set; } = null!;
}
