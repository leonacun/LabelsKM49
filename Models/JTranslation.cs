using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTranslation
{
    public decimal TraId { get; set; }

    public decimal TraTextId { get; set; }

    public decimal TraLanguageId { get; set; }

    public DateTime TraTcreation { get; set; }

    public string TraText { get; set; } = null!;

    public virtual JLanguage TraLanguage { get; set; } = null!;

    public virtual JText TraTextNavigation { get; set; } = null!;
}
