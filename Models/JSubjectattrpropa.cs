using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectattrpropa
{
    public decimal SapId { get; set; }

    public decimal SapSubjectcomptypeId { get; set; }

    public decimal SapSourcesubjtypeId { get; set; }

    public decimal SapDestsubjtypeId { get; set; }

    public decimal SapSubjectattrId { get; set; }

    public DateTime SapTcreation { get; set; }

    public DateTime SapTupdate { get; set; }

    public virtual JSubjectattr SapDestsubjtype { get; set; } = null!;

    public virtual JSubjectattr SapSourcesubjtype { get; set; } = null!;

    public virtual JSubjectattr SapSubjectattr { get; set; } = null!;

    public virtual JSubjectcomptype SapSubjectcomptype { get; set; } = null!;
}
