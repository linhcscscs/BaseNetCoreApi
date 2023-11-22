using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class MapMienGiamHsSo
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public long IdDmMienGiamSo { get; set; }

    public int IdChHs { get; set; }

    public string GiaTriHs { get; set; } = null!;

    public string? TenGiaTri { get; set; }

    public virtual ChH IdChHsNavigation { get; set; } = null!;

    public virtual DmMienGiamSo IdDmMienGiamSoNavigation { get; set; } = null!;
}
