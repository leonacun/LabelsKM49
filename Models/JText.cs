using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JText
{
    public decimal TxId { get; set; }

    public decimal TxTextcategoryId { get; set; }

    public DateTime TxTcreation { get; set; }

    public string TxKey { get; set; } = null!;

    public virtual ICollection<JTranslation> JTranslations { get; set; } = new List<JTranslation>();

    public virtual JTextcategory TxTextcategory { get; set; } = null!;
}
