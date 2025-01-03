using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTextcategory
{
    public decimal TxcId { get; set; }

    public DateTime TxcTcreation { get; set; }

    public string TxcKey { get; set; } = null!;

    public string TxcType { get; set; } = null!;

    public string? TxcTablename { get; set; }

    public string? TxcIdcolumnname { get; set; }

    public virtual ICollection<JText> JTexts { get; set; } = new List<JText>();
}
