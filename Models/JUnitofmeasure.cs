using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUnitofmeasure
{
    public decimal UomId { get; set; }

    public decimal? UomRefunitId { get; set; }

    public DateTime UomTcreation { get; set; }

    public DateTime UomTupdate { get; set; }

    public string UomCode { get; set; } = null!;

    public string UomShortname { get; set; } = null!;

    public string UomDescr { get; set; } = null!;

    public string UomFamily { get; set; } = null!;

    public decimal UomFactor { get; set; }

    public decimal UomFactordenominator { get; set; }

    public virtual ICollection<JUnitofmeasure> InverseUomRefunit { get; set; } = new List<JUnitofmeasure>();

    public virtual ICollection<JContainersubject> JContainersubjects { get; set; } = new List<JContainersubject>();

    public virtual ICollection<JContainertype> JContainertypeCttDimuoms { get; set; } = new List<JContainertype>();

    public virtual ICollection<JContainertype> JContainertypeCttWeightuoms { get; set; } = new List<JContainertype>();

    public virtual ICollection<JContractcumulative> JContractcumulatives { get; set; } = new List<JContractcumulative>();

    public virtual ICollection<JContractentry> JContractentries { get; set; } = new List<JContractentry>();

    public virtual ICollection<JMaintdefmaterial> JMaintdefmaterials { get; set; } = new List<JMaintdefmaterial>();

    public virtual ICollection<JMaintjobmaterial> JMaintjobmaterials { get; set; } = new List<JMaintjobmaterial>();

    public virtual ICollection<JMeasurement> JMeasurements { get; set; } = new List<JMeasurement>();

    public virtual ICollection<JOrderentry> JOrderentries { get; set; } = new List<JOrderentry>();

    public virtual ICollection<JOrderentryinfo> JOrderentryinfos { get; set; } = new List<JOrderentryinfo>();

    public virtual ICollection<JOrderinfo> JOrderinfos { get; set; } = new List<JOrderinfo>();

    public virtual ICollection<JSubjectclassdefelem> JSubjectclassdefelems { get; set; } = new List<JSubjectclassdefelem>();

    public virtual ICollection<JSubjectcompelem> JSubjectcompelemSceProdunitofmeasures { get; set; } = new List<JSubjectcompelem>();

    public virtual ICollection<JSubjectcompelem> JSubjectcompelemSceUnitofmeasures { get; set; } = new List<JSubjectcompelem>();

    public virtual ICollection<JSubject> JSubjects { get; set; } = new List<JSubject>();

    public virtual ICollection<JSupplynoteentry> JSupplynoteentrySuneConfirmedunitofmeasures { get; set; } = new List<JSupplynoteentry>();

    public virtual ICollection<JSupplynoteentry> JSupplynoteentrySuneUnitofmeasures { get; set; } = new List<JSupplynoteentry>();

    public virtual JUnitofmeasure? UomRefunit { get; set; }
}
