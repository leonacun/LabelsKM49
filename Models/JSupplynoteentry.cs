using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSupplynoteentry
{
    public decimal SuneId { get; set; }

    public decimal SuneSupplynoteId { get; set; }

    public decimal SuneSubjectId { get; set; }

    public decimal? SuneOthersubjectId { get; set; }

    public decimal? SuneContractorderId { get; set; }

    public decimal? SuneUnitofmeasureId { get; set; }

    public decimal? SuneConfirmedunitofmeasureId { get; set; }

    public DateTime SuneTcreation { get; set; }

    public int SuneNo { get; set; }

    public decimal SuneAmount { get; set; }

    public decimal SuneConfirmedamount { get; set; }

    public decimal SuneCumulatedamount { get; set; }

    public string? SunePackageinfo1 { get; set; }

    public string? SunePackageinfo2 { get; set; }

    public DateTime SuneTupdate { get; set; }

    public virtual ICollection<JSupplynoteentryorder> JSupplynoteentryorders { get; set; } = new List<JSupplynoteentryorder>();

    public virtual JUnitofmeasure? SuneConfirmedunitofmeasure { get; set; }

    public virtual JOrder? SuneContractorder { get; set; }

    public virtual JSubject? SuneOthersubject { get; set; }

    public virtual JSubject SuneSubject { get; set; } = null!;

    public virtual JSupplynote SuneSupplynote { get; set; } = null!;

    public virtual JUnitofmeasure? SuneUnitofmeasure { get; set; }
}
