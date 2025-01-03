using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkid
{
    public decimal SkId { get; set; }

    public decimal SkSkidsetId { get; set; }

    public decimal? SkPaintunitId { get; set; }

    public decimal? SkSkidtypeId { get; set; }

    public decimal? SkLastskidtypeId { get; set; }

    public DateTime SkTcreation { get; set; }

    public DateTime SkTupdate { get; set; }

    public string SkCode { get; set; } = null!;

    public string? SkDescr { get; set; }

    public byte? SkPos { get; set; }

    public int SkCyclecount { get; set; }

    public decimal? SkColorId { get; set; }

    public bool? SkNeedsmaintenance { get; set; }

    public string SkState { get; set; } = null!;

    public decimal? SkContainerId { get; set; }

    public virtual ICollection<JPaintunitstateelem> JPaintunitstateelems { get; set; } = new List<JPaintunitstateelem>();

    public virtual ICollection<JPolyconpaintevent> JPolyconpaintevents { get; set; } = new List<JPolyconpaintevent>();

    public virtual ICollection<JSkidbufferentry> JSkidbufferentries { get; set; } = new List<JSkidbufferentry>();

    public virtual ICollection<JSkiddatum> JSkiddata { get; set; } = new List<JSkiddatum>();

    public virtual ICollection<JSkidevent> JSkidevents { get; set; } = new List<JSkidevent>();

    public virtual ICollection<JSkidinfo> JSkidinfos { get; set; } = new List<JSkidinfo>();

    public virtual JColor? SkColor { get; set; }

    public virtual JContainer? SkContainer { get; set; }

    public virtual JSkidtype? SkLastskidtype { get; set; }

    public virtual JPaintunit? SkPaintunit { get; set; }

    public virtual JSkidset SkSkidset { get; set; } = null!;

    public virtual JSkidtype? SkSkidtype { get; set; }
}
