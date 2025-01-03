using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JReportparam
{
    public decimal RpId { get; set; }

    public decimal RpReportId { get; set; }

    public decimal? RpStockId { get; set; }

    public decimal? RpSubjectclassId { get; set; }

    public decimal? RpDemandcategoryId { get; set; }

    public decimal? RpParentId { get; set; }

    public decimal? RpProdstepId { get; set; }

    public decimal? RpProdunitId { get; set; }

    public decimal? RpCalendarId { get; set; }

    public decimal? RpContractId { get; set; }

    public decimal? RpSubjectattrId { get; set; }

    public decimal? RpJoinedreportId { get; set; }

    public DateTime RpTcreation { get; set; }

    public string RpName { get; set; } = null!;

    public byte RpPosno { get; set; }

    public string RpValuetype { get; set; } = null!;

    public string? RpStringvalue { get; set; }

    public int? RpIntvalue { get; set; }

    public decimal? RpDecimalvalue { get; set; }

    public int? RpDatasize { get; set; }

    public byte[]? RpData { get; set; }

    public DateTime RpTupdate { get; set; }

    public virtual ICollection<JReportparam> InverseRpParent { get; set; } = new List<JReportparam>();

    public virtual JCalendar? RpCalendar { get; set; }

    public virtual JContract? RpContract { get; set; }

    public virtual JDemandcategory? RpDemandcategory { get; set; }

    public virtual JReport? RpJoinedreport { get; set; }

    public virtual JReportparam? RpParent { get; set; }

    public virtual JProdstep? RpProdstep { get; set; }

    public virtual JProdunit? RpProdunit { get; set; }

    public virtual JReport RpReport { get; set; } = null!;

    public virtual JStock? RpStock { get; set; }

    public virtual JSubjectattr? RpSubjectattr { get; set; }

    public virtual JSubjectclass? RpSubjectclass { get; set; }
}
