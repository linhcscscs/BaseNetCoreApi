using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class MapMienGiamH
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public long IdDmMienGiam { get; set; }

    public int IdChHs { get; set; }

    public string GiaTriHs { get; set; } = null!;

    public string? TenGiaTri { get; set; }

    public virtual ChH IdChHsNavigation { get; set; } = null!;

    public virtual DmMienGiam IdDmMienGiamNavigation { get; set; } = null!;
}
