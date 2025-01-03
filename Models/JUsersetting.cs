using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUsersetting
{
    public decimal UseId { get; set; }

    public decimal UseUserId { get; set; }

    public DateTime UseTcreation { get; set; }

    public DateTime UseTupdate { get; set; }

    public string UseType { get; set; } = null!;

    public string? UseKey1 { get; set; }

    public string? UseKey2 { get; set; }

    public string? UseKey3 { get; set; }

    public string? UseKey4 { get; set; }

    public DateTime? UseTimevalue { get; set; }

    public string? UseStringvalue { get; set; }

    public int UseIntvalue { get; set; }

    public decimal? UseUserroleId { get; set; }

    public virtual JUser UseUser { get; set; } = null!;

    public virtual JUserrole? UseUserrole { get; set; }
}
