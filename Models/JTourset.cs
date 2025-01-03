using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTourset
{
    public decimal TsId { get; set; }

    public decimal TsCompanyId { get; set; }

    public decimal? TsDoccfgId { get; set; }

    public decimal? TsDemandcategoryId { get; set; }

    public decimal? TsAdvdemandcategoryId { get; set; }

    public DateTime TsTcreation { get; set; }

    public DateTime TsTupdate { get; set; }

    public string TsKey { get; set; } = null!;

    public string TsDescr { get; set; } = null!;

    public string TsSchedule { get; set; } = null!;

    public byte TsMaxlocations { get; set; }

    public virtual ICollection<JLoadercontrol> JLoadercontrols { get; set; } = new List<JLoadercontrol>();

    public virtual ICollection<JToureventcfg> JToureventcfgs { get; set; } = new List<JToureventcfg>();

    public virtual ICollection<JTour> JTours { get; set; } = new List<JTour>();

    public virtual ICollection<JTourtemplate> JTourtemplates { get; set; } = new List<JTourtemplate>();

    public virtual JDemandcategory? TsAdvdemandcategory { get; set; }

    public virtual JCompany TsCompany { get; set; } = null!;

    public virtual JDemandcategory? TsDemandcategory { get; set; }

    public virtual JDoccfg? TsDoccfg { get; set; }
}
