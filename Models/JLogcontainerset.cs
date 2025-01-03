using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogcontainerset
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string CtsKey { get; set; } = null!;

    public string CtsDescr { get; set; } = null!;

    public string? CtsShortdescr { get; set; }

    public string? CtsSheettype { get; set; }

    public string? CtsAltsheettype { get; set; }

    public string? CtsLabeltype { get; set; }

    public string CtsDeliverymode { get; set; } = null!;

    public string CtsLoadingmode { get; set; } = null!;

    public string? CtsLoadingparams { get; set; }

    public string CtsVerificationmode { get; set; } = null!;

    public bool CtsHasevents { get; set; }

    public bool? CtsUniquenos { get; set; }

    public decimal? CtsParentId { get; set; }

    public decimal? CtsCounterId { get; set; }

    public decimal? CtsOthercounterId { get; set; }

    public decimal? CtsContainerusageId { get; set; }

    public decimal? CtsContainertypeId { get; set; }

    public decimal? CtsCompanyId { get; set; }

    public decimal? CtsProdplanId { get; set; }

    public decimal? CtsDoccfgId { get; set; }

    public decimal? CtsStockId { get; set; }

    public bool? CtsInventory { get; set; }

    public decimal? CtsAltcounterId { get; set; }

    public decimal? CtsScriptdefId { get; set; }

    public decimal? CtsEdicfgId { get; set; }

    public bool? CtsHassnapshots { get; set; }

    public decimal? CtsContainertypeclassId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
