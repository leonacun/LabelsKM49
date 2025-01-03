using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectattr
{
    public decimal SaId { get; set; }

    public decimal SaCompanyId { get; set; }

    public decimal? SaChoiceId { get; set; }

    public DateTime SaTcreation { get; set; }

    public DateTime SaTupdate { get; set; }

    public string SaKeyincompany { get; set; } = null!;

    public string SaDescr { get; set; } = null!;

    public byte SaPosno { get; set; }

    public string SaType { get; set; } = null!;

    public byte? SaLength { get; set; }

    public byte? SaDecimals { get; set; }

    public string? SaUomfamily { get; set; }

    public string SaValuetablename { get; set; } = null!;

    public string SaValuecolumnname { get; set; } = null!;

    public string? SaValueuomcolumnname { get; set; }

    public string SaSubjectcolumnname { get; set; } = null!;

    public bool SaIssynchronized { get; set; }

    public virtual ICollection<JContainermapcfg> JContainermapcfgs { get; set; } = new List<JContainermapcfg>();

    public virtual ICollection<JReportparam> JReportparams { get; set; } = new List<JReportparam>();

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JSubjectattrinfo> JSubjectattrinfos { get; set; } = new List<JSubjectattrinfo>();

    public virtual ICollection<JSubjectattrpropa> JSubjectattrpropaSapDestsubjtypes { get; set; } = new List<JSubjectattrpropa>();

    public virtual ICollection<JSubjectattrpropa> JSubjectattrpropaSapSourcesubjtypes { get; set; } = new List<JSubjectattrpropa>();

    public virtual ICollection<JSubjectattrpropa> JSubjectattrpropaSapSubjectattrs { get; set; } = new List<JSubjectattrpropa>();

    public virtual ICollection<JSubjectclassdefelem> JSubjectclassdefelems { get; set; } = new List<JSubjectclassdefelem>();

    public virtual ICollection<JSubjecttypeattr> JSubjecttypeattrs { get; set; } = new List<JSubjecttypeattr>();

    public virtual JChoice? SaChoice { get; set; }

    public virtual JCompany SaCompany { get; set; } = null!;
}
