using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDemandcategory
{
    public decimal DcId { get; set; }

    public decimal DcCompanyId { get; set; }

    public DateTime DcTcreation { get; set; }

    public DateTime DcTupdate { get; set; }

    public string DcKey { get; set; } = null!;

    public string DcDescr { get; set; } = null!;

    public virtual JCompany DcCompany { get; set; } = null!;

    public virtual ICollection<JDemandcategoryinfo> JDemandcategoryinfos { get; set; } = new List<JDemandcategoryinfo>();

    public virtual ICollection<JDemand> JDemands { get; set; } = new List<JDemand>();

    public virtual ICollection<JPaintunit> JPaintunitPauAltdemandcategories { get; set; } = new List<JPaintunit>();

    public virtual ICollection<JPaintunit> JPaintunitPauDemandcategories { get; set; } = new List<JPaintunit>();

    public virtual ICollection<JReportparam> JReportparams { get; set; } = new List<JReportparam>();

    public virtual ICollection<JTourset> JToursetTsAdvdemandcategories { get; set; } = new List<JTourset>();

    public virtual ICollection<JTourset> JToursetTsDemandcategories { get; set; } = new List<JTourset>();
}
