using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectclassdefelem
{
    public decimal ScldeId { get; set; }

    public decimal ScldeSubjectclassId { get; set; }

    public decimal? ScldeInsubjectclassId { get; set; }

    public decimal? ScldeSubjecttypeId { get; set; }

    public decimal? ScldeSubjectattrId { get; set; }

    public DateTime ScldeTcreation { get; set; }

    public DateTime ScldeTupdate { get; set; }

    public string? ScldeValues { get; set; }

    public string? ScldeSubjectnopattern { get; set; }

    public byte[]? ScldeQuery { get; set; }

    public decimal? ScldeSubjectstatusId { get; set; }

    public decimal? ScldeUnitofmeasureId { get; set; }

    public virtual JSubjectclass? ScldeInsubjectclass { get; set; }

    public virtual JSubjectattr? ScldeSubjectattr { get; set; }

    public virtual JSubjectclass ScldeSubjectclass { get; set; } = null!;

    public virtual JSubjectstatus? ScldeSubjectstatus { get; set; }

    public virtual JSubjecttype? ScldeSubjecttype { get; set; }

    public virtual JUnitofmeasure? ScldeUnitofmeasure { get; set; }
}
