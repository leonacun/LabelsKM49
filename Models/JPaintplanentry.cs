using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintplanentry
{
    public decimal PpeId { get; set; }

    public decimal PpePaintplanId { get; set; }

    public decimal PpeSkidtypeId { get; set; }

    public decimal? PpeColorId { get; set; }

    public DateTime PpeTcreation { get; set; }

    public DateTime PpeTupdate { get; set; }

    public byte PpePos { get; set; }

    public byte PpeVersion { get; set; }

    public string PpeState { get; set; } = null!;

    public string? PpeSyncid { get; set; }

    public string? PpeBackupforsyncid { get; set; }

    public string? PpeLastsyncret { get; set; }

    public bool PpeSyncenabled { get; set; }

    public bool PpePrimerenabled { get; set; }

    public decimal PpeQuantity { get; set; }

    public decimal PpeLoadedquantity { get; set; }

    public decimal PpeUnloadedquantity { get; set; }

    public string? PpeSkidusageshortname { get; set; }

    public string? PpeInfo1 { get; set; }

    public string? PpeInfo2 { get; set; }

    public DateTime? PpeTimebeginunloading { get; set; }

    public DateTime? PpeTimebeginloading { get; set; }

    public virtual ICollection<JPaintplanentrydemand> JPaintplanentrydemands { get; set; } = new List<JPaintplanentrydemand>();

    public virtual ICollection<JPaintplanentryelem> JPaintplanentryelems { get; set; } = new List<JPaintplanentryelem>();

    public virtual ICollection<JPaintplanentryinfo> JPaintplanentryinfos { get; set; } = new List<JPaintplanentryinfo>();

    public virtual ICollection<JPaintunitstateelem> JPaintunitstateelems { get; set; } = new List<JPaintunitstateelem>();

    public virtual ICollection<JPaintunitstate> JPaintunitstates { get; set; } = new List<JPaintunitstate>();

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual ICollection<JSkidinfo> JSkidinfos { get; set; } = new List<JSkidinfo>();

    public virtual JColor? PpeColor { get; set; }

    public virtual JPaintplan PpePaintplan { get; set; } = null!;

    public virtual JSkidtype PpeSkidtype { get; set; } = null!;
}
