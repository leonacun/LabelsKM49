using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDoccfg
{
    public decimal DcfId { get; set; }

    public decimal DcfCompanyId { get; set; }

    public DateTime DcfTcreation { get; set; }

    public DateTime DcfTupdate { get; set; }

    public string DcfKey { get; set; } = null!;

    public string? DcfDescr { get; set; }

    public virtual JCompany DcfCompany { get; set; } = null!;

    public virtual ICollection<JContainerset> JContainersets { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContract> JContracts { get; set; } = new List<JContract>();

    public virtual ICollection<JDelivery> JDeliveries { get; set; } = new List<JDelivery>();

    public virtual ICollection<JDoccfgitem> JDoccfgitems { get; set; } = new List<JDoccfgitem>();

    public virtual ICollection<JMaintjobset> JMaintjobsets { get; set; } = new List<JMaintjobset>();

    public virtual ICollection<JPart> JParts { get; set; } = new List<JPart>();

    public virtual ICollection<JPartset> JPartsets { get; set; } = new List<JPartset>();

    public virtual ICollection<JProdlotset> JProdlotsets { get; set; } = new List<JProdlotset>();

    public virtual ICollection<JProdnoteset> JProdnotesets { get; set; } = new List<JProdnoteset>();

    public virtual ICollection<JProdstep> JProdsteps { get; set; } = new List<JProdstep>();

    public virtual ICollection<JProdunit> JProdunits { get; set; } = new List<JProdunit>();

    public virtual ICollection<JSkidset> JSkidsets { get; set; } = new List<JSkidset>();

    public virtual ICollection<JStock> JStocks { get; set; } = new List<JStock>();

    public virtual ICollection<JStocktagset> JStocktagsets { get; set; } = new List<JStocktagset>();

    public virtual ICollection<JSubjecttype> JSubjecttypes { get; set; } = new List<JSubjecttype>();

    public virtual ICollection<JSupply> JSupplies { get; set; } = new List<JSupply>();

    public virtual ICollection<JTourset> JToursets { get; set; } = new List<JTourset>();

    public virtual ICollection<JUserset> JUsersets { get; set; } = new List<JUserset>();
}
