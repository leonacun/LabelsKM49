using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectstatus
{
    public decimal SstId { get; set; }

    public DateTime SstTcreation { get; set; }

    public DateTime SstTupdate { get; set; }

    public string SstCode { get; set; } = null!;

    public string SstDescr { get; set; } = null!;

    public bool SstIseditable { get; set; }

    public bool SstOpship { get; set; }

    public bool SstOpreceive { get; set; }

    public bool SstOpstock { get; set; }

    public bool SstOpproduce { get; set; }

    public bool SstOpconsume { get; set; }

    public bool SstOpsale { get; set; }

    public bool SstOppurchase { get; set; }

    public virtual ICollection<JSubjectclassdefelem> JSubjectclassdefelems { get; set; } = new List<JSubjectclassdefelem>();

    public virtual ICollection<JSubject> JSubjects { get; set; } = new List<JSubject>();
}
