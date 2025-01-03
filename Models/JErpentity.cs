using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JErpentity
{
    public decimal EeId { get; set; }

    public decimal EeErpentitysetId { get; set; }

    public decimal EeErpentitytypeId { get; set; }

    public DateTime EeTcreation { get; set; }

    public DateTime EeTupdate { get; set; }

    public string EeKey { get; set; } = null!;

    public string? EeDescr { get; set; }

    public string EeName { get; set; } = null!;

    public string? EeValue { get; set; }

    public virtual JErpentityset EeErpentityset { get; set; } = null!;

    public virtual JErpentitytype EeErpentitytype { get; set; } = null!;

    public virtual ICollection<JContractinfo> JContractinfos { get; set; } = new List<JContractinfo>();

    public virtual ICollection<JProdstepinfo> JProdstepinfos { get; set; } = new List<JProdstepinfo>();

    public virtual ICollection<JProdunitinfo> JProdunitinfos { get; set; } = new List<JProdunitinfo>();

    public virtual ICollection<JProdversioninfo> JProdversioninfos { get; set; } = new List<JProdversioninfo>();

    public virtual ICollection<JPvssarea> JPvssareaPvaPlants { get; set; } = new List<JPvssarea>();

    public virtual ICollection<JPvssarea> JPvssareaPvaStorages { get; set; } = new List<JPvssarea>();

    public virtual ICollection<JStockinfo> JStockinfos { get; set; } = new List<JStockinfo>();

    public virtual ICollection<JStocklocinfo> JStocklocinfos { get; set; } = new List<JStocklocinfo>();
}
