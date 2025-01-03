using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFile
{
    public decimal FiId { get; set; }

    public decimal FiFilesetId { get; set; }

    public DateTime FiTcreation { get; set; }

    public DateTime FiTupdate { get; set; }

    public decimal? FiDeletionid { get; set; }

    public DateTime? FiTdeletion { get; set; }

    public string? FiKey { get; set; }

    public string FiDescr { get; set; } = null!;

    public string? FiFilename { get; set; }

    public string? FiEncoding { get; set; }

    public int FiDatasize { get; set; }

    public byte[] FiData { get; set; } = null!;

    public virtual JFileset FiFileset { get; set; } = null!;

    public virtual ICollection<JAdvice> JAdvices { get; set; } = new List<JAdvice>();

    public virtual ICollection<JMaintdefinstr> JMaintdefinstrs { get; set; } = new List<JMaintdefinstr>();

    public virtual ICollection<JMaintjobdatum> JMaintjobdata { get; set; } = new List<JMaintjobdatum>();
}
