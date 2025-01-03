using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUser
{
    public decimal UId { get; set; }

    public decimal UUsersetId { get; set; }

    public decimal? UMenuId { get; set; }

    public decimal? UDefaultuserroleId { get; set; }

    public DateTime UTcreation { get; set; }

    public DateTime UTupdate { get; set; }

    public decimal? UDeletionid { get; set; }

    public DateTime? UTdeletion { get; set; }

    public string UShortname { get; set; } = null!;

    public string UPassword { get; set; } = null!;

    public string UDescr { get; set; } = null!;

    public string? UFirstname { get; set; }

    public string? ULastname { get; set; }

    public string? UNo { get; set; }

    public string? UCardid { get; set; }

    public string? UEmail { get; set; }

    public DateTime? UTimelastlogin { get; set; }

    public decimal? ULoginpolicyId { get; set; }

    public string UAuthentication { get; set; } = null!;

    public virtual ICollection<JAdvice> JAdviceAdvAuthors { get; set; } = new List<JAdvice>();

    public virtual ICollection<JAdvice> JAdviceAdvConfirmedbyusers { get; set; } = new List<JAdvice>();

    public virtual ICollection<JAdviceconfirmation> JAdviceconfirmations { get; set; } = new List<JAdviceconfirmation>();

    public virtual ICollection<JCalendarentry> JCalendarentryCaeAuthors { get; set; } = new List<JCalendarentry>();

    public virtual ICollection<JCalendarentry> JCalendarentryCaeUsers { get; set; } = new List<JCalendarentry>();

    public virtual ICollection<JGroupmember> JGroupmembers { get; set; } = new List<JGroupmember>();

    public virtual ICollection<JLoginpolicyitem> JLoginpolicyitems { get; set; } = new List<JLoginpolicyitem>();

    public virtual ICollection<JMaintprov> JMaintprovs { get; set; } = new List<JMaintprov>();

    public virtual ICollection<JObjectcache> JObjectcaches { get; set; } = new List<JObjectcache>();

    public virtual ICollection<JProdtooladvice> JProdtooladvices { get; set; } = new List<JProdtooladvice>();

    public virtual ICollection<JProdunitadvice> JProdunitadvices { get; set; } = new List<JProdunitadvice>();

    public virtual ICollection<JSearchdef> JSearchdefs { get; set; } = new List<JSearchdef>();

    public virtual ICollection<JStocktag> JStocktags { get; set; } = new List<JStocktag>();

    public virtual ICollection<JSupplyentry> JSupplyentries { get; set; } = new List<JSupplyentry>();

    public virtual ICollection<JSupplynotecontainer> JSupplynotecontainers { get; set; } = new List<JSupplynotecontainer>();

    public virtual ICollection<JSupplynote> JSupplynotes { get; set; } = new List<JSupplynote>();

    public virtual ICollection<JTicket> JTicketTicAuthors { get; set; } = new List<JTicket>();

    public virtual ICollection<JTicket> JTicketTicProcessors { get; set; } = new List<JTicket>();

    public virtual ICollection<JToken> JTokens { get; set; } = new List<JToken>();

    public virtual ICollection<JTour> JTours { get; set; } = new List<JTour>();

    public virtual ICollection<JUserinfo> JUserinfos { get; set; } = new List<JUserinfo>();

    public virtual ICollection<JUserqualification> JUserqualifications { get; set; } = new List<JUserqualification>();

    public virtual ICollection<JUsersetting> JUsersettings { get; set; } = new List<JUsersetting>();

    public virtual ICollection<JWorktime> JWorktimes { get; set; } = new List<JWorktime>();

    public virtual JUserrole? UDefaultuserrole { get; set; }

    public virtual JLoginpolicy? ULoginpolicy { get; set; }

    public virtual JMenu? UMenu { get; set; }

    public virtual JUserset UUserset { get; set; } = null!;
}
