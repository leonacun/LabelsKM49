using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLanguage
{
    public decimal LngId { get; set; }

    public DateTime LngTcreation { get; set; }

    public string LngKey { get; set; } = null!;

    public virtual ICollection<JTranslation> JTranslations { get; set; } = new List<JTranslation>();
}
