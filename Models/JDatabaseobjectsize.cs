using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDatabaseobjectsize
{
    public decimal DosId { get; set; }

    public DateTime DosTcreation { get; set; }

    public DateTime DosStatusdate { get; set; }

    public string DosObjectname { get; set; } = null!;

    public long DosBytes { get; set; }

    public long DosBlocks { get; set; }
}
