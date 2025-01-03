using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainersubjectmark
{
    public decimal CtesmId { get; set; }

    public decimal CtesmContainersubjectId { get; set; }

    public decimal? CtesmTourcontainerId { get; set; }

    public DateTime CtesmTcreation { get; set; }

    public DateTime CtesmTupdate { get; set; }

    public virtual JContainersubject CtesmContainersubject { get; set; } = null!;

    public virtual JTourcontainer? CtesmTourcontainer { get; set; }
}
