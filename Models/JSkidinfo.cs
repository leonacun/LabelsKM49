using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidinfo
{
    public decimal SkiId { get; set; }

    public decimal SkiPaintplanId { get; set; }

    public decimal? SkiPaintplanentryId { get; set; }

    public DateTime SkiTcreation { get; set; }

    public DateTime SkiTupdate { get; set; }

    public byte SkiSkidpos { get; set; }

    public string? SkiSkidname { get; set; }

    public string? SkiSkidinfo1 { get; set; }

    public string? SkiSkidinfo2 { get; set; }

    public DateTime? SkiTimeloaded { get; set; }

    public DateTime? SkiTimeunloaded { get; set; }

    public bool SkiIndicator1 { get; set; }

    public bool SkiIndicator2 { get; set; }

    public decimal? SkiSkidId { get; set; }

    public int SkiSkidsequenceno { get; set; }

    public virtual ICollection<JPaintunitstateelem> JPaintunitstateelems { get; set; } = new List<JPaintunitstateelem>();

    public virtual ICollection<JPolyconpaintevent> JPolyconpainteventDpcpeSkidinfo1s { get; set; } = new List<JPolyconpaintevent>();

    public virtual ICollection<JPolyconpaintevent> JPolyconpainteventDpcpeSkidinfo2s { get; set; } = new List<JPolyconpaintevent>();

    public virtual ICollection<JSkidinfoelem> JSkidinfoelems { get; set; } = new List<JSkidinfoelem>();

    public virtual ICollection<JSkidinfoinfo> JSkidinfoinfos { get; set; } = new List<JSkidinfoinfo>();

    public virtual JPaintplan SkiPaintplan { get; set; } = null!;

    public virtual JPaintplanentry? SkiPaintplanentry { get; set; }

    public virtual JSkid? SkiSkid { get; set; }
}
