using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMeasurement
{
    public decimal MeId { get; set; }

    public decimal MeMeasurementsetId { get; set; }

    public decimal? MeSubjectId { get; set; }

    public decimal? MeUomId { get; set; }

    public decimal? MePartId { get; set; }

    public DateTime MeTcreation { get; set; }

    public string? MeType { get; set; }

    public decimal MeValue { get; set; }

    public string? MeInfo1 { get; set; }

    public string? MeInfo2 { get; set; }

    public decimal? MeProdunitId { get; set; }

    public virtual JMeasurementset MeMeasurementset { get; set; } = null!;

    public virtual JPart? MePart { get; set; }

    public virtual JProdunit? MeProdunit { get; set; }

    public virtual JSubject? MeSubject { get; set; }

    public virtual JUnitofmeasure? MeUom { get; set; }
}
