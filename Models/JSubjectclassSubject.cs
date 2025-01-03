using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectclassSubject
{
    public decimal SubjectclassId { get; set; }

    public decimal SubjectId { get; set; }

    public DateTime Tcreation { get; set; }

    public virtual JSubject Subject { get; set; } = null!;

    public virtual JSubjectclass Subjectclass { get; set; } = null!;
}
