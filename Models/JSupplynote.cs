using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSupplynote
{
    public decimal SunId { get; set; }

    public decimal SunSupplyentryId { get; set; }

    public decimal? SunLocationId { get; set; }

    public decimal? SunConfirmedbyuserId { get; set; }

    public decimal? SunHandledbycontainerId { get; set; }

    public DateTime SunTcreation { get; set; }

    public decimal? SunDeletionid { get; set; }

    public DateTime? SunTdeletion { get; set; }

    public string SunNo { get; set; } = null!;

    public string? SunErpno { get; set; }

    public bool SunConfirmed { get; set; }

    public DateTime? SunTimeverified { get; set; }

    public DateTime? SunReceipttimestamp { get; set; }

    public decimal? SunConfirmedbyprodunitId { get; set; }

    public string? SunQualifier1 { get; set; }

    public string? SunQualifier2 { get; set; }

    public DateTime? SunTimeadvised { get; set; }

    public DateTime? SunTimedelivered { get; set; }

    public DateTime? SunTimearrived { get; set; }

    public DateTime? SunTimearrivalconfirmed { get; set; }

    public DateTime? SunTimeissued { get; set; }

    public DateTime SunTupdate { get; set; }

    public virtual ICollection<JSupplynotecontainer> JSupplynotecontainers { get; set; } = new List<JSupplynotecontainer>();

    public virtual ICollection<JSupplynoteentry> JSupplynoteentries { get; set; } = new List<JSupplynoteentry>();

    public virtual ICollection<JSupplynoteinfo> JSupplynoteinfos { get; set; } = new List<JSupplynoteinfo>();

    public virtual ICollection<JSupplynoteorder> JSupplynoteorders { get; set; } = new List<JSupplynoteorder>();

    public virtual ICollection<JSupplynotepart> JSupplynoteparts { get; set; } = new List<JSupplynotepart>();

    public virtual JProdunit? SunConfirmedbyprodunit { get; set; }

    public virtual JUser? SunConfirmedbyuser { get; set; }

    public virtual JContainer? SunHandledbycontainer { get; set; }

    public virtual JLocation? SunLocation { get; set; }

    public virtual JSupplyentry SunSupplyentry { get; set; } = null!;
}
