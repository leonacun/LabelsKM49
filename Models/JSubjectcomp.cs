using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectcomp
{
    public decimal ScId { get; set; }

    public decimal ScSubjectcomptypeId { get; set; }

    public decimal ScProducedsubjectId { get; set; }

    public DateTime ScTcreation { get; set; }

    public DateTime ScTupdate { get; set; }

    public decimal? ScInvalidid { get; set; }

    public DateTime? ScTvalidfrom { get; set; }

    public DateTime? ScTvaliduntil { get; set; }

    public virtual ICollection<JSubjectcompelem> JSubjectcompelems { get; set; } = new List<JSubjectcompelem>();

    public virtual JSubject ScProducedsubject { get; set; } = null!;

    public virtual JSubjectcomptype ScSubjectcomptype { get; set; } = null!;
}
