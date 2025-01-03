using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjecttypeattr
{
    public decimal StaId { get; set; }

    public decimal StaSubjecttypeId { get; set; }

    public decimal StaSubjectattrId { get; set; }

    public DateTime StaTcreation { get; set; }

    public DateTime StaTupdate { get; set; }

    public byte StaPosno { get; set; }

    public virtual JSubjectattr StaSubjectattr { get; set; } = null!;

    public virtual JSubjecttype StaSubjecttype { get; set; } = null!;
}
