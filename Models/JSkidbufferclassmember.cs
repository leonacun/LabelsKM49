using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidbufferclassmember
{
    public decimal SkbcmId { get; set; }

    public decimal SkbcmSkidbufferclassId { get; set; }

    public decimal SkbcmSkidbufferId { get; set; }

    public DateTime SkbcmTcreation { get; set; }

    public DateTime SkbcmTupdate { get; set; }

    public virtual JSkidbuffer SkbcmSkidbuffer { get; set; } = null!;

    public virtual JSkidbufferclass SkbcmSkidbufferclass { get; set; } = null!;
}
